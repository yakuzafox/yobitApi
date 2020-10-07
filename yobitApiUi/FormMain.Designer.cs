namespace yobitApiUi
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPair = new System.Windows.Forms.ListBox();
            this.labelSelectedPair = new System.Windows.Forms.Label();
            this.checkBoxUSDT = new System.Windows.Forms.CheckBox();
            this.checkBoxRUR = new System.Windows.Forms.CheckBox();
            this.checkBoxUSD = new System.Windows.Forms.CheckBox();
            this.checkBoxW = new System.Windows.Forms.CheckBox();
            this.checkBoxYO = new System.Windows.Forms.CheckBox();
            this.checkBoxDOGE = new System.Windows.Forms.CheckBox();
            this.checkBoxETH = new System.Windows.Forms.CheckBox();
            this.checkBoxBTC = new System.Windows.Forms.CheckBox();
            this.textBoxSearchPair = new System.Windows.Forms.TextBox();
            this.comboBoxConvertPair = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.dataGridViewParser = new System.Windows.Forms.DataGridView();
            this.Pair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCurrency = new System.Windows.Forms.Panel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timerReloadParse = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAllPair = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).BeginInit();
            this.panelCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1048, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.toolStripMenuFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.toolStripMenuHelp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuHelp.Text = "Help";
            // 
            // listBoxPair
            // 
            this.listBoxPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.listBoxPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPair.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.listBoxPair.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPair.FormattingEnabled = true;
            this.listBoxPair.ItemHeight = 23;
            this.listBoxPair.Location = new System.Drawing.Point(5, 93);
            this.listBoxPair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPair.Name = "listBoxPair";
            this.listBoxPair.Size = new System.Drawing.Size(248, 301);
            this.listBoxPair.TabIndex = 1;
            this.listBoxPair.SelectedIndexChanged += new System.EventHandler(this.listBoxPair_SelectedIndexChanged);
            // 
            // labelSelectedPair
            // 
            this.labelSelectedPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.labelSelectedPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedPair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectedPair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSelectedPair.Location = new System.Drawing.Point(5, 16);
            this.labelSelectedPair.Name = "labelSelectedPair";
            this.labelSelectedPair.Size = new System.Drawing.Size(248, 40);
            this.labelSelectedPair.TabIndex = 2;
            this.labelSelectedPair.Text = "SelectedPair";
            this.labelSelectedPair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxUSDT
            // 
            this.checkBoxUSDT.AutoSize = true;
            this.checkBoxUSDT.ForeColor = System.Drawing.Color.White;
            this.checkBoxUSDT.Location = new System.Drawing.Point(449, 10);
            this.checkBoxUSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUSDT.Name = "checkBoxUSDT";
            this.checkBoxUSDT.Size = new System.Drawing.Size(68, 21);
            this.checkBoxUSDT.TabIndex = 0;
            this.checkBoxUSDT.Text = "USDT";
            this.checkBoxUSDT.UseVisualStyleBackColor = true;
            // 
            // checkBoxRUR
            // 
            this.checkBoxRUR.AutoSize = true;
            this.checkBoxRUR.ForeColor = System.Drawing.Color.White;
            this.checkBoxRUR.Location = new System.Drawing.Point(384, 10);
            this.checkBoxRUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxRUR.Name = "checkBoxRUR";
            this.checkBoxRUR.Size = new System.Drawing.Size(60, 21);
            this.checkBoxRUR.TabIndex = 0;
            this.checkBoxRUR.Text = "RUR";
            this.checkBoxRUR.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSD
            // 
            this.checkBoxUSD.AutoSize = true;
            this.checkBoxUSD.ForeColor = System.Drawing.Color.White;
            this.checkBoxUSD.Location = new System.Drawing.Point(318, 10);
            this.checkBoxUSD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUSD.Name = "checkBoxUSD";
            this.checkBoxUSD.Size = new System.Drawing.Size(59, 21);
            this.checkBoxUSD.TabIndex = 0;
            this.checkBoxUSD.Text = "USD";
            this.checkBoxUSD.UseVisualStyleBackColor = true;
            // 
            // checkBoxW
            // 
            this.checkBoxW.AutoSize = true;
            this.checkBoxW.ForeColor = System.Drawing.Color.White;
            this.checkBoxW.Location = new System.Drawing.Point(267, 10);
            this.checkBoxW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxW.Name = "checkBoxW";
            this.checkBoxW.Size = new System.Drawing.Size(43, 21);
            this.checkBoxW.TabIndex = 0;
            this.checkBoxW.Text = "W";
            this.checkBoxW.UseVisualStyleBackColor = true;
            // 
            // checkBoxYO
            // 
            this.checkBoxYO.AutoSize = true;
            this.checkBoxYO.ForeColor = System.Drawing.Color.White;
            this.checkBoxYO.Location = new System.Drawing.Point(212, 10);
            this.checkBoxYO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxYO.Name = "checkBoxYO";
            this.checkBoxYO.Size = new System.Drawing.Size(50, 21);
            this.checkBoxYO.TabIndex = 0;
            this.checkBoxYO.Text = "YO";
            this.checkBoxYO.UseVisualStyleBackColor = true;
            // 
            // checkBoxDOGE
            // 
            this.checkBoxDOGE.AutoSize = true;
            this.checkBoxDOGE.ForeColor = System.Drawing.Color.White;
            this.checkBoxDOGE.Location = new System.Drawing.Point(135, 10);
            this.checkBoxDOGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDOGE.Name = "checkBoxDOGE";
            this.checkBoxDOGE.Size = new System.Drawing.Size(71, 21);
            this.checkBoxDOGE.TabIndex = 0;
            this.checkBoxDOGE.Text = "DOGE";
            this.checkBoxDOGE.UseVisualStyleBackColor = true;
            // 
            // checkBoxETH
            // 
            this.checkBoxETH.AutoSize = true;
            this.checkBoxETH.ForeColor = System.Drawing.Color.White;
            this.checkBoxETH.Location = new System.Drawing.Point(71, 10);
            this.checkBoxETH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxETH.Name = "checkBoxETH";
            this.checkBoxETH.Size = new System.Drawing.Size(58, 21);
            this.checkBoxETH.TabIndex = 0;
            this.checkBoxETH.Text = "ETH";
            this.checkBoxETH.UseVisualStyleBackColor = true;
            // 
            // checkBoxBTC
            // 
            this.checkBoxBTC.AutoSize = true;
            this.checkBoxBTC.ForeColor = System.Drawing.Color.White;
            this.checkBoxBTC.Location = new System.Drawing.Point(10, 10);
            this.checkBoxBTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBTC.Name = "checkBoxBTC";
            this.checkBoxBTC.Size = new System.Drawing.Size(57, 21);
            this.checkBoxBTC.TabIndex = 0;
            this.checkBoxBTC.Text = "BTC";
            this.checkBoxBTC.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPair
            // 
            this.textBoxSearchPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxSearchPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchPair.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchPair.Location = new System.Drawing.Point(5, 66);
            this.textBoxSearchPair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearchPair.Name = "textBoxSearchPair";
            this.textBoxSearchPair.Size = new System.Drawing.Size(248, 22);
            this.textBoxSearchPair.TabIndex = 4;
            this.textBoxSearchPair.TextChanged += new System.EventHandler(this.textBoxSearchPair_TextChanged);
            // 
            // comboBoxConvertPair
            // 
            this.comboBoxConvertPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxConvertPair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConvertPair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxConvertPair.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxConvertPair.FormattingEnabled = true;
            this.comboBoxConvertPair.Items.AddRange(new object[] {
            "BTC",
            "ETH",
            "DOGE",
            "YO",
            "W",
            "USD",
            "RUR",
            "USDT"});
            this.comboBoxConvertPair.Location = new System.Drawing.Point(437, 63);
            this.comboBoxConvertPair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxConvertPair.Name = "comboBoxConvertPair";
            this.comboBoxConvertPair.Size = new System.Drawing.Size(168, 24);
            this.comboBoxConvertPair.TabIndex = 5;
            this.comboBoxConvertPair.SelectedIndexChanged += new System.EventHandler(this.comboBoxConvertPair_SelectedIndexChanged);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1024, 452);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.textBoxLink);
            this.tabPage1.Controls.Add(this.dataGridViewParser);
            this.tabPage1.Controls.Add(this.panelCurrency);
            this.tabPage1.Controls.Add(this.buttonFind);
            this.tabPage1.Controls.Add(this.labelSelectedPair);
            this.tabPage1.Controls.Add(this.listBoxPair);
            this.tabPage1.Controls.Add(this.comboBoxConvertPair);
            this.tabPage1.Controls.Add(this.textBoxSearchPair);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1016, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parser";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.Location = new System.Drawing.Point(263, 396);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.ReadOnly = true;
            this.textBoxLink.Size = new System.Drawing.Size(747, 22);
            this.textBoxLink.TabIndex = 12;
            // 
            // dataGridViewParser
            // 
            this.dataGridViewParser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewParser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pair,
            this.Price,
            this.Buy,
            this.Sell});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParser.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewParser.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewParser.Location = new System.Drawing.Point(263, 93);
            this.dataGridViewParser.Name = "dataGridViewParser";
            this.dataGridViewParser.ReadOnly = true;
            this.dataGridViewParser.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewParser.RowTemplate.Height = 24;
            this.dataGridViewParser.Size = new System.Drawing.Size(747, 301);
            this.dataGridViewParser.TabIndex = 11;
            // 
            // Pair
            // 
            this.Pair.HeaderText = "Pair";
            this.Pair.MinimumWidth = 6;
            this.Pair.Name = "Pair";
            this.Pair.ReadOnly = true;
            this.Pair.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Buy";
            this.Buy.MinimumWidth = 6;
            this.Buy.Name = "Buy";
            this.Buy.ReadOnly = true;
            this.Buy.Width = 125;
            // 
            // Sell
            // 
            this.Sell.HeaderText = "Sell";
            this.Sell.MinimumWidth = 6;
            this.Sell.Name = "Sell";
            this.Sell.ReadOnly = true;
            this.Sell.Width = 125;
            // 
            // panelCurrency
            // 
            this.panelCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrency.Controls.Add(this.checkBoxAllPair);
            this.panelCurrency.Controls.Add(this.checkBoxUSDT);
            this.panelCurrency.Controls.Add(this.checkBoxBTC);
            this.panelCurrency.Controls.Add(this.checkBoxRUR);
            this.panelCurrency.Controls.Add(this.checkBoxETH);
            this.panelCurrency.Controls.Add(this.checkBoxDOGE);
            this.panelCurrency.Controls.Add(this.checkBoxUSD);
            this.panelCurrency.Controls.Add(this.checkBoxYO);
            this.panelCurrency.Controls.Add(this.checkBoxW);
            this.panelCurrency.Location = new System.Drawing.Point(263, 16);
            this.panelCurrency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelCurrency.Name = "panelCurrency";
            this.panelCurrency.Size = new System.Drawing.Size(615, 40);
            this.panelCurrency.TabIndex = 9;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Green;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonFind.ForeColor = System.Drawing.Color.Black;
            this.buttonFind.Location = new System.Drawing.Point(636, 62);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(127, 26);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Start";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1016, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // timerReloadParse
            // 
            this.timerReloadParse.Enabled = true;
            this.timerReloadParse.Interval = 1000;
            this.timerReloadParse.Tick += new System.EventHandler(this.timerReloadParse_Tick);
            // 
            // checkBoxAllPair
            // 
            this.checkBoxAllPair.AutoSize = true;
            this.checkBoxAllPair.ForeColor = System.Drawing.Color.White;
            this.checkBoxAllPair.Location = new System.Drawing.Point(523, 9);
            this.checkBoxAllPair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAllPair.Name = "checkBoxAllPair";
            this.checkBoxAllPair.Size = new System.Drawing.Size(74, 21);
            this.checkBoxAllPair.TabIndex = 1;
            this.checkBoxAllPair.Text = "All Pair";
            this.checkBoxAllPair.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1048, 479);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "ApiClientYobit";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).EndInit();
            this.panelCurrency.ResumeLayout(false);
            this.panelCurrency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.ListBox listBoxPair;
        private System.Windows.Forms.Label labelSelectedPair;
        private System.Windows.Forms.CheckBox checkBoxUSDT;
        private System.Windows.Forms.CheckBox checkBoxRUR;
        private System.Windows.Forms.CheckBox checkBoxUSD;
        private System.Windows.Forms.CheckBox checkBoxW;
        private System.Windows.Forms.CheckBox checkBoxYO;
        private System.Windows.Forms.CheckBox checkBoxDOGE;
        private System.Windows.Forms.CheckBox checkBoxETH;
        private System.Windows.Forms.CheckBox checkBoxBTC;
        private System.Windows.Forms.TextBox textBoxSearchPair;
        private System.Windows.Forms.ComboBox comboBoxConvertPair;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Panel panelCurrency;
        private System.Windows.Forms.DataGridView dataGridViewParser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.Timer timerReloadParse;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.CheckBox checkBoxAllPair;
    }
}

