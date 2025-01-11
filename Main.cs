using System.Text.Json;
using System.Threading;

namespace ArkaikSyncItemsOptions
{
    public partial class Main : Form
    {
        private const string ITEMS_SERVER_FILE = "items_rozero.yml";
        private const string ITEMS_RANDOM_OPT_FILE = "item_randomopt_db.yml";
        private const string ITEMS_CLIENT_EQUIP_FILE = "ItemsRaEquip.json";

        private YamlClass<ItemRoZero> _itemsServer;
        private YamlClass<ItemRandomOpt> _itemsRandomOpt;
        private List<ItemRaEquip> _itemsClient;
        private ConverterService _Service;

        private bool ItemsServerIsValid = false;
        private bool ItemsRandomOptIsValid = false;
        private bool ItemsClientIsValid = false;
        private bool EnabledProcess = false;
        private bool EnabledSave = false;

        public Main()
        {
            InitializeComponent();
        }

        private ConverterService Converter()
        {
            if (_Service == null)
                _Service = new ConverterService();

            return _Service;
        }

        private void ValidateState()
        {
            ItemsServerIsValid = _itemsServer?.Body?.Any() ?? false;
            ItemsRandomOptIsValid = _itemsRandomOpt?.Body?.Any() ?? false;
            ItemsClientIsValid = _itemsClient?.Any() ?? false;

            EnabledProcess = ItemsServerIsValid && ItemsRandomOptIsValid && ItemsClientIsValid;

            Btn_Start.Enabled = EnabledProcess && !EnabledSave;
            btn_Save.Enabled = EnabledSave && EnabledProcess;
        }

        private void Btn_ItemsServer_Click(object sender, EventArgs e)
        {
            string itemsServerPath = PickFile(ITEMS_SERVER_FILE);
            Txb_ItemsServer.Text = itemsServerPath;
            _itemsServer = Converter().ExtractObjectYaml<ItemRoZero>(itemsServerPath);
            ValidateState();
        }

        private void btn_ServerEnum_Click(object sender, EventArgs e)
        {
            string itemsOptPath = PickFile(ITEMS_RANDOM_OPT_FILE);
            txb_ServerEnum.Text = itemsOptPath;
            _itemsRandomOpt = Converter().ExtractObjectYaml<ItemRandomOpt>(itemsOptPath);
            ValidateState();
        }

        private void btn_ItensEquipClient_Click(object sender, EventArgs e)
        {
            string itemsClientPath = PickFile(ITEMS_CLIENT_EQUIP_FILE);
            txb_ItensEquipClient.Text = itemsClientPath;
            _itemsClient = Converter().ExtractObjects<ItemRaEquip>(itemsClientPath);
            ValidateState();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Btn_Start.Enabled = false;

            _itemsClient.ForEach(item =>
            {
                var itemServer = _itemsServer.Body.Find(i => i.Item == item.Id);
                if (itemServer == null) return;
                item.Modifier = itemServer.Modifier.Select(serverModifer => new ItemModifier
                {
                    Level = serverModifer.Level,
                    Durability = serverModifer.Durability,
                    RandomOption = serverModifer.RandomOption?.Select(mod =>
                    {
                        var optDb = _itemsRandomOpt.Body.Find(opt => opt.Option == mod.Option.Replace("RDMOPT_", ""));
                        return new RandomOption
                        {
                            Id = optDb.Id,
                            Min = mod.Min,
                            Max = mod.Max,
                        };
                    })
                    .ToList(),
                })
                .ToList();
            });

            EnabledSave = true;
            ValidateState();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (SaveJson(Path.GetFileNameWithoutExtension(ITEMS_CLIENT_EQUIP_FILE), _itemsClient))
            {
                MessageBox.Show("Arquivo exportado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnabledSave = false;
            };
            ValidateState();
        }

        private bool SaveJson<T>(string name, List<T> list)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Arquivo JSON (*.json)|*.json", // Define o filtro de extensão do arquivo
                Title = $"Salvar {name} JSON",
                FileName = $"{name}.json" // Nome inicial do arquivo
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    string json = JsonSerializer.Serialize(list, new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                        DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
                    });
                    File.WriteAllText(filePath, json);
                    return true;
                }
                catch
                {
                    MessageBox.Show($"Falha ao tentar escrever {name}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private string PickFile(string fileName)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = $"{fileName}|{fileName}";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Verifica se o arquivo selecionado corresponde ao esperado
                string selectedFile = ofd.FileName;

                if (!Path.GetFileName(selectedFile).Equals(fileName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Arquivo inválido! Selecione o arquivo '{fileName}'.", "Erro");
                    return null;
                }

                return selectedFile;
            }
            return null;
        }
    }
}
