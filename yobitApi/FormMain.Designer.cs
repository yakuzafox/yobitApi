namespace yobitApi
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelBTC = new System.Windows.Forms.Label();
            this.panelCurrency = new System.Windows.Forms.Panel();
            this.buttonFind = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
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
            this.menuStripMain.Size = new System.Drawing.Size(1004, 28);
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
            this.listBoxPair.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPair.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxPair.FormattingEnabled = true;
            this.listBoxPair.ItemHeight = 23;
            this.listBoxPair.Location = new System.Drawing.Point(5, 116);
            this.listBoxPair.Name = "listBoxPair";
            this.listBoxPair.Size = new System.Drawing.Size(248, 324);
            this.listBoxPair.TabIndex = 1;
            this.listBoxPair.SelectedIndexChanged += new System.EventHandler(this.listBoxPair_SelectedIndexChanged);
            // 
            // labelSelectedPair
            // 
            this.labelSelectedPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.labelSelectedPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedPair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedPair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSelectedPair.Location = new System.Drawing.Point(5, 34);
            this.labelSelectedPair.Name = "labelSelectedPair";
            this.labelSelectedPair.Size = new System.Drawing.Size(248, 36);
            this.labelSelectedPair.TabIndex = 2;
            this.labelSelectedPair.Text = "SelectedPair";
            this.labelSelectedPair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBoxUSDT
            // 
            this.checkBoxUSDT.AutoSize = true;
            this.checkBoxUSDT.ForeColor = System.Drawing.Color.White;
            this.checkBoxUSDT.Location = new System.Drawing.Point(449, 12);
            this.checkBoxUSDT.Name = "checkBoxUSDT";
            this.checkBoxUSDT.Size = new System.Drawing.Size(67, 24);
            this.checkBoxUSDT.TabIndex = 0;
            this.checkBoxUSDT.Text = "USDT";
            this.checkBoxUSDT.UseVisualStyleBackColor = true;
            // 
            // checkBoxRUR
            // 
            this.checkBoxRUR.AutoSize = true;
            this.checkBoxRUR.ForeColor = System.Drawing.Color.White;
            this.checkBoxRUR.Location = new System.Drawing.Point(384, 12);
            this.checkBoxRUR.Name = "checkBoxRUR";
            this.checkBoxRUR.Size = new System.Drawing.Size(59, 24);
            this.checkBoxRUR.TabIndex = 0;
            this.checkBoxRUR.Text = "RUR";
            this.checkBoxRUR.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSD
            // 
            this.checkBoxUSD.AutoSize = true;
            this.checkBoxUSD.ForeColor = System.Drawing.Color.White;
            this.checkBoxUSD.Location = new System.Drawing.Point(318, 12);
            this.checkBoxUSD.Name = "checkBoxUSD";
            this.checkBoxUSD.Size = new System.Drawing.Size(60, 24);
            this.checkBoxUSD.TabIndex = 0;
            this.checkBoxUSD.Text = "USD";
            this.checkBoxUSD.UseVisualStyleBackColor = true;
            // 
            // checkBoxW
            // 
            this.checkBoxW.AutoSize = true;
            this.checkBoxW.ForeColor = System.Drawing.Color.White;
            this.checkBoxW.Location = new System.Drawing.Point(267, 12);
            this.checkBoxW.Name = "checkBoxW";
            this.checkBoxW.Size = new System.Drawing.Size(45, 24);
            this.checkBoxW.TabIndex = 0;
            this.checkBoxW.Text = "W";
            this.checkBoxW.UseVisualStyleBackColor = true;
            // 
            // checkBoxYO
            // 
            this.checkBoxYO.AutoSize = true;
            this.checkBoxYO.ForeColor = System.Drawing.Color.White;
            this.checkBoxYO.Location = new System.Drawing.Point(212, 12);
            this.checkBoxYO.Name = "checkBoxYO";
            this.checkBoxYO.Size = new System.Drawing.Size(49, 24);
            this.checkBoxYO.TabIndex = 0;
            this.checkBoxYO.Text = "YO";
            this.checkBoxYO.UseVisualStyleBackColor = true;
            // 
            // checkBoxDOGE
            // 
            this.checkBoxDOGE.AutoSize = true;
            this.checkBoxDOGE.ForeColor = System.Drawing.Color.White;
            this.checkBoxDOGE.Location = new System.Drawing.Point(135, 12);
            this.checkBoxDOGE.Name = "checkBoxDOGE";
            this.checkBoxDOGE.Size = new System.Drawing.Size(71, 24);
            this.checkBoxDOGE.TabIndex = 0;
            this.checkBoxDOGE.Text = "DOGE";
            this.checkBoxDOGE.UseVisualStyleBackColor = true;
            // 
            // checkBoxETH
            // 
            this.checkBoxETH.AutoSize = true;
            this.checkBoxETH.ForeColor = System.Drawing.Color.White;
            this.checkBoxETH.Location = new System.Drawing.Point(71, 12);
            this.checkBoxETH.Name = "checkBoxETH";
            this.checkBoxETH.Size = new System.Drawing.Size(58, 24);
            this.checkBoxETH.TabIndex = 0;
            this.checkBoxETH.Text = "ETH";
            this.checkBoxETH.UseVisualStyleBackColor = true;
            // 
            // checkBoxBTC
            // 
            this.checkBoxBTC.AutoSize = true;
            this.checkBoxBTC.ForeColor = System.Drawing.Color.White;
            this.checkBoxBTC.Location = new System.Drawing.Point(10, 12);
            this.checkBoxBTC.Name = "checkBoxBTC";
            this.checkBoxBTC.Size = new System.Drawing.Size(55, 24);
            this.checkBoxBTC.TabIndex = 0;
            this.checkBoxBTC.Text = "BTC";
            this.checkBoxBTC.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPair
            // 
            this.textBoxSearchPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxSearchPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchPair.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchPair.Location = new System.Drawing.Point(5, 83);
            this.textBoxSearchPair.Name = "textBoxSearchPair";
            this.textBoxSearchPair.PlaceholderText = " Search";
            this.textBoxSearchPair.Size = new System.Drawing.Size(248, 27);
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
            this.comboBoxConvertPair.Location = new System.Drawing.Point(260, 83);
            this.comboBoxConvertPair.Name = "comboBoxConvertPair";
            this.comboBoxConvertPair.Size = new System.Drawing.Size(151, 28);
            this.comboBoxConvertPair.TabIndex = 5;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 31);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(980, 514);
            this.tabControlMain.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanelMain);
            this.tabPage1.Controls.Add(this.panelCurrency);
            this.tabPage1.Controls.Add(this.buttonFind);
            this.tabPage1.Controls.Add(this.labelSelectedPair);
            this.tabPage1.Controls.Add(this.listBoxPair);
            this.tabPage1.Controls.Add(this.comboBoxConvertPair);
            this.tabPage1.Controls.Add(this.textBoxSearchPair);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parser";
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.label26, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.label25, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.label24, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.label23, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.label21, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelBTC, 0, 1);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(260, 116);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16071F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(698, 324);
            this.tableLayoutPanelMain.TabIndex = 10;
            // 
            // labelBTC
            // 
            this.labelBTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.labelBTC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBTC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBTC.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelBTC.Location = new System.Drawing.Point(3, 33);
            this.labelBTC.Name = "labelBTC";
            this.labelBTC.Size = new System.Drawing.Size(168, 33);
            this.labelBTC.TabIndex = 2;
            this.labelBTC.Text = "BTC";
            this.labelBTC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelCurrency
            // 
            this.panelCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCurrency.Controls.Add(this.checkBoxUSDT);
            this.panelCurrency.Controls.Add(this.checkBoxBTC);
            this.panelCurrency.Controls.Add(this.checkBoxRUR);
            this.panelCurrency.Controls.Add(this.checkBoxETH);
            this.panelCurrency.Controls.Add(this.checkBoxDOGE);
            this.panelCurrency.Controls.Add(this.checkBoxUSD);
            this.panelCurrency.Controls.Add(this.checkBoxYO);
            this.panelCurrency.Controls.Add(this.checkBoxW);
            this.panelCurrency.Location = new System.Drawing.Point(259, 20);
            this.panelCurrency.Name = "panelCurrency";
            this.panelCurrency.Size = new System.Drawing.Size(615, 50);
            this.panelCurrency.TabIndex = 9;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(437, 83);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(130, 29);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(351, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "SelectedPair";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(177, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 39);
            this.label5.TabIndex = 2;
            this.label5.Text = "SelectedPair";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(3, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "SelectedPair";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(177, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 39);
            this.label7.TabIndex = 2;
            this.label7.Text = "SelectedPair";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(3, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "SelectedPair";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(351, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 39);
            this.label9.TabIndex = 2;
            this.label9.Text = "SelectedPair";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(525, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 39);
            this.label10.TabIndex = 2;
            this.label10.Text = "SelectedPair";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(351, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(168, 39);
            this.label11.TabIndex = 2;
            this.label11.Text = "SelectedPair";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(525, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 39);
            this.label12.TabIndex = 2;
            this.label12.Text = "SelectedPair";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(3, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 39);
            this.label13.TabIndex = 2;
            this.label13.Text = "SelectedPair";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(177, 316);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 39);
            this.label14.TabIndex = 2;
            this.label14.Text = "SelectedPair";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(3, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(168, 39);
            this.label15.TabIndex = 2;
            this.label15.Text = "SelectedPair";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "BTC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label21.Location = new System.Drawing.Point(3, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(168, 33);
            this.label21.TabIndex = 2;
            this.label21.Text = "BTC";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label22.Location = new System.Drawing.Point(3, 165);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(168, 33);
            this.label22.TabIndex = 2;
            this.label22.Text = "BTC";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label23.Location = new System.Drawing.Point(3, 198);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 33);
            this.label23.TabIndex = 2;
            this.label23.Text = "BTC";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label24.Location = new System.Drawing.Point(3, 231);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(168, 33);
            this.label24.TabIndex = 2;
            this.label24.Text = "BTC";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label25.Location = new System.Drawing.Point(3, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(168, 33);
            this.label25.TabIndex = 2;
            this.label25.Text = "BTC";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label26.Location = new System.Drawing.Point(3, 296);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(168, 28);
            this.label26.TabIndex = 2;
            this.label26.Text = "BTC";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1004, 548);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "ApiClientYobit";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelBTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label2;
    }
}

