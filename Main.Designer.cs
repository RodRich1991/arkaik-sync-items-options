namespace ArkaikSyncItemsOptions
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpFiles = new GroupBox();
            btn_ServerEnum = new Button();
            btn_ItensEquipClient = new Button();
            txb_ItensEquipClient = new TextBox();
            txb_ServerEnum = new TextBox();
            lbl_ClientEquipItems = new Label();
            Btn_ItemsServer = new Button();
            lbl_ServerItemEnum = new Label();
            Txb_ItemsServer = new TextBox();
            lbItemsServer = new Label();
            Btn_Start = new Button();
            btn_Save = new Button();
            gpFiles.SuspendLayout();
            SuspendLayout();
            // 
            // gpFiles
            // 
            gpFiles.Controls.Add(btn_ServerEnum);
            gpFiles.Controls.Add(btn_ItensEquipClient);
            gpFiles.Controls.Add(txb_ItensEquipClient);
            gpFiles.Controls.Add(txb_ServerEnum);
            gpFiles.Controls.Add(lbl_ClientEquipItems);
            gpFiles.Controls.Add(Btn_ItemsServer);
            gpFiles.Controls.Add(lbl_ServerItemEnum);
            gpFiles.Controls.Add(Txb_ItemsServer);
            gpFiles.Controls.Add(lbItemsServer);
            gpFiles.Location = new Point(12, 12);
            gpFiles.Name = "gpFiles";
            gpFiles.Size = new Size(728, 207);
            gpFiles.TabIndex = 0;
            gpFiles.TabStop = false;
            gpFiles.Text = "Arquivos";
            // 
            // btn_ServerEnum
            // 
            btn_ServerEnum.BackgroundImage = Properties.Resources.folder_icon;
            btn_ServerEnum.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ServerEnum.Location = new Point(697, 108);
            btn_ServerEnum.Name = "btn_ServerEnum";
            btn_ServerEnum.Size = new Size(27, 27);
            btn_ServerEnum.TabIndex = 12;
            btn_ServerEnum.UseVisualStyleBackColor = true;
            btn_ServerEnum.Click += btn_ServerEnum_Click;
            // 
            // btn_ItensEquipClient
            // 
            btn_ItensEquipClient.BackgroundImage = Properties.Resources.folder_icon;
            btn_ItensEquipClient.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ItensEquipClient.Location = new Point(697, 169);
            btn_ItensEquipClient.Name = "btn_ItensEquipClient";
            btn_ItensEquipClient.Size = new Size(27, 27);
            btn_ItensEquipClient.TabIndex = 9;
            btn_ItensEquipClient.UseVisualStyleBackColor = true;
            btn_ItensEquipClient.Click += btn_ItensEquipClient_Click;
            // 
            // txb_ItensEquipClient
            // 
            txb_ItensEquipClient.Location = new Point(6, 169);
            txb_ItensEquipClient.Name = "txb_ItensEquipClient";
            txb_ItensEquipClient.ReadOnly = true;
            txb_ItensEquipClient.Size = new Size(685, 23);
            txb_ItensEquipClient.TabIndex = 8;
            // 
            // txb_ServerEnum
            // 
            txb_ServerEnum.Location = new Point(6, 108);
            txb_ServerEnum.Name = "txb_ServerEnum";
            txb_ServerEnum.ReadOnly = true;
            txb_ServerEnum.Size = new Size(685, 23);
            txb_ServerEnum.TabIndex = 11;
            // 
            // lbl_ClientEquipItems
            // 
            lbl_ClientEquipItems.AutoSize = true;
            lbl_ClientEquipItems.Location = new Point(6, 151);
            lbl_ClientEquipItems.Name = "lbl_ClientEquipItems";
            lbl_ClientEquipItems.Size = new Size(207, 15);
            lbl_ClientEquipItems.TabIndex = 7;
            lbl_ClientEquipItems.Text = "Client Equip Itens (ItemsRaEquip.json)";
            // 
            // Btn_ItemsServer
            // 
            Btn_ItemsServer.BackgroundImage = Properties.Resources.folder_icon;
            Btn_ItemsServer.BackgroundImageLayout = ImageLayout.Stretch;
            Btn_ItemsServer.Location = new Point(697, 49);
            Btn_ItemsServer.Name = "Btn_ItemsServer";
            Btn_ItemsServer.Size = new Size(27, 27);
            Btn_ItemsServer.TabIndex = 3;
            Btn_ItemsServer.UseVisualStyleBackColor = true;
            Btn_ItemsServer.Click += Btn_ItemsServer_Click;
            // 
            // lbl_ServerItemEnum
            // 
            lbl_ServerItemEnum.AutoSize = true;
            lbl_ServerItemEnum.Location = new Point(6, 90);
            lbl_ServerItemEnum.Name = "lbl_ServerItemEnum";
            lbl_ServerItemEnum.Size = new Size(262, 15);
            lbl_ServerItemEnum.TabIndex = 10;
            lbl_ServerItemEnum.Text = "Server ItemOpt Enum (item_randomopt_db.yml)";
            // 
            // Txb_ItemsServer
            // 
            Txb_ItemsServer.Location = new Point(6, 49);
            Txb_ItemsServer.Name = "Txb_ItemsServer";
            Txb_ItemsServer.ReadOnly = true;
            Txb_ItemsServer.Size = new Size(685, 23);
            Txb_ItemsServer.TabIndex = 2;
            // 
            // lbItemsServer
            // 
            lbItemsServer.AutoSize = true;
            lbItemsServer.Location = new Point(6, 31);
            lbItemsServer.Name = "lbItemsServer";
            lbItemsServer.Size = new Size(172, 15);
            lbItemsServer.TabIndex = 0;
            lbItemsServer.Text = "Server Items (items_rozero.yml)";
            // 
            // Btn_Start
            // 
            Btn_Start.Enabled = false;
            Btn_Start.Image = Properties.Resources.play_20;
            Btn_Start.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Start.Location = new Point(249, 225);
            Btn_Start.Name = "Btn_Start";
            Btn_Start.Size = new Size(91, 44);
            Btn_Start.TabIndex = 2;
            Btn_Start.Text = "Start";
            Btn_Start.UseVisualStyleBackColor = true;
            Btn_Start.Click += Btn_Start_Click;
            // 
            // btn_Save
            // 
            btn_Save.Enabled = false;
            btn_Save.Image = Properties.Resources.Save_icon_20png;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(425, 225);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(91, 44);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 288);
            Controls.Add(btn_Save);
            Controls.Add(Btn_Start);
            Controls.Add(gpFiles);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Arkaik Itens Options Sync";
            gpFiles.ResumeLayout(false);
            gpFiles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpFiles;
        private Label lbItemsServer;
        private TextBox Txb_ItemsServer;
        private Button Btn_ItemsServer;
        private Button btn_ItensEquipClient;
        private TextBox txb_ItensEquipClient;
        private Label lbl_ClientEquipItems;
        private Button Btn_Start;
        private Button btn_Save;
        private Button btn_ServerEnum;
        private TextBox txb_ServerEnum;
        private Label lbl_ServerItemEnum;
    }
}
