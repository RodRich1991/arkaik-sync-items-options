using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkaikSyncItemsOptions
{
    internal class YamlClass<T>
    {
        public Header Header { get; set; }
        public List<T> Body { get; set; }
    }

    public class Header
    {
        public string Type { get; set; }     // Tipo do banco de dados
        public int Version { get; set; }    // Versão do banco de dados
    }
}
