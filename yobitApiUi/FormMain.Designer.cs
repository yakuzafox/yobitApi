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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPair = new System.Windows.Forms.ListBox();
            this.labelSelectedPair = new System.Windows.Forms.Label();
            this.textBoxSearchPair = new System.Windows.Forms.TextBox();
            this.comboBoxConvertPair = new System.Windows.Forms.ComboBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Parser = new System.Windows.Forms.TabPage();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.dataGridViewParser = new System.Windows.Forms.DataGridView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.Bot = new System.Windows.Forms.TabPage();
            this.timerReloadParse = new System.Windows.Forms.Timer(this.components);
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.Pair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxExchange = new System.Windows.Forms.ComboBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.Parser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).BeginInit();
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
            this.listBoxPair.Size = new System.Drawing.Size(248, 439);
            this.listBoxPair.TabIndex = 1;
            this.listBoxPair.SelectedIndexChanged += new System.EventHandler(this.listBoxPair_SelectedIndexChanged);
            // 
            // labelSelectedPair
            // 
            this.labelSelectedPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.labelSelectedPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSelectedPair.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSelectedPair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSelectedPair.Location = new System.Drawing.Point(5, 20);
            this.labelSelectedPair.Name = "labelSelectedPair";
            this.labelSelectedPair.Size = new System.Drawing.Size(248, 36);
            this.labelSelectedPair.TabIndex = 2;
            this.labelSelectedPair.Text = "SelectedPair";
            this.labelSelectedPair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxSearchPair
            // 
            this.textBoxSearchPair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxSearchPair.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearchPair.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxSearchPair.Location = new System.Drawing.Point(5, 64);
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
            this.comboBoxConvertPair.Location = new System.Drawing.Point(450, 62);
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
            this.tabControlMain.Controls.Add(this.Parser);
            this.tabControlMain.Controls.Add(this.Bot);
            this.tabControlMain.Location = new System.Drawing.Point(12, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1024, 568);
            this.tabControlMain.TabIndex = 7;
            // 
            // Parser
            // 
            this.Parser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Parser.Controls.Add(this.comboBoxExchange);
            this.Parser.Controls.Add(this.textBoxLog);
            this.Parser.Controls.Add(this.textBoxLink);
            this.Parser.Controls.Add(this.dataGridViewParser);
            this.Parser.Controls.Add(this.buttonFind);
            this.Parser.Controls.Add(this.labelSelectedPair);
            this.Parser.Controls.Add(this.listBoxPair);
            this.Parser.Controls.Add(this.comboBoxConvertPair);
            this.Parser.Controls.Add(this.textBoxSearchPair);
            this.Parser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Parser.Location = new System.Drawing.Point(4, 25);
            this.Parser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parser.Name = "Parser";
            this.Parser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Parser.Size = new System.Drawing.Size(1016, 539);
            this.Parser.TabIndex = 0;
            this.Parser.Text = "Parser";
            // 
            // textBoxLink
            // 
            this.textBoxLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.textBoxLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLink.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxLink.Location = new System.Drawing.Point(263, 423);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.ReadOnly = true;
            this.textBoxLink.Size = new System.Drawing.Size(747, 22);
            this.textBoxLink.TabIndex = 12;
            // 
            // dataGridViewParser
            // 
            this.dataGridViewParser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewParser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewParser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pair,
            this.Ask,
            this.Bid,
            this.Buy,
            this.Sell});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParser.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewParser.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewParser.Location = new System.Drawing.Point(263, 93);
            this.dataGridViewParser.Name = "dataGridViewParser";
            this.dataGridViewParser.ReadOnly = true;
            this.dataGridViewParser.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.dataGridViewParser.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewParser.RowTemplate.Height = 24;
            this.dataGridViewParser.Size = new System.Drawing.Size(747, 324);
            this.dataGridViewParser.TabIndex = 11;
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
            // Bot
            // 
            this.Bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Bot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.Bot.Location = new System.Drawing.Point(4, 25);
            this.Bot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bot.Name = "Bot";
            this.Bot.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bot.Size = new System.Drawing.Size(1016, 539);
            this.Bot.TabIndex = 1;
            this.Bot.Text = "Bot";
            // 
            // timerReloadParse
            // 
            this.timerReloadParse.Enabled = true;
            this.timerReloadParse.Interval = 1000;
            this.timerReloadParse.Tick += new System.EventHandler(this.timerReloadParse_Tick);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxLog.Location = new System.Drawing.Point(263, 451);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(747, 82);
            this.textBoxLog.TabIndex = 13;
            // 
            // Pair
            // 
            this.Pair.HeaderText = "Pair";
            this.Pair.MinimumWidth = 6;
            this.Pair.Name = "Pair";
            this.Pair.ReadOnly = true;
            this.Pair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Pair.Width = 125;
            // 
            // Ask
            // 
            this.Ask.HeaderText = "Ask";
            this.Ask.MinimumWidth = 6;
            this.Ask.Name = "Ask";
            this.Ask.ReadOnly = true;
            this.Ask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ask.Width = 125;
            // 
            // Bid
            // 
            this.Bid.HeaderText = "Bid";
            this.Bid.MinimumWidth = 6;
            this.Bid.Name = "Bid";
            this.Bid.ReadOnly = true;
            this.Bid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Bid.Width = 125;
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Buy";
            this.Buy.MinimumWidth = 6;
            this.Buy.Name = "Buy";
            this.Buy.ReadOnly = true;
            this.Buy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Buy.Width = 125;
            // 
            // Sell
            // 
            this.Sell.HeaderText = "Sell";
            this.Sell.MinimumWidth = 6;
            this.Sell.Name = "Sell";
            this.Sell.ReadOnly = true;
            this.Sell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Sell.Width = 125;
            // 
            // comboBoxExchange
            // 
            this.comboBoxExchange.AutoCompleteCustomSource.AddRange(new string[] {
            "Binance",
            "Yobit"});
            this.comboBoxExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxExchange.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxExchange.FormattingEnabled = true;
            this.comboBoxExchange.Items.AddRange(new object[] {
            "Binance",
            "Yobit"});
            this.comboBoxExchange.Location = new System.Drawing.Point(263, 62);
            this.comboBoxExchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxExchange.Name = "comboBoxExchange";
            this.comboBoxExchange.Size = new System.Drawing.Size(168, 24);
            this.comboBoxExchange.TabIndex = 14;
            this.comboBoxExchange.SelectedIndexChanged += new System.EventHandler(this.comboBoxExchange_SelectedIndexChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1048, 595);
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
            this.Parser.ResumeLayout(false);
            this.Parser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.ListBox listBoxPair;
        private System.Windows.Forms.Label labelSelectedPair;
        private System.Windows.Forms.TextBox textBoxSearchPair;
        private System.Windows.Forms.ComboBox comboBoxConvertPair;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage Parser;
        private System.Windows.Forms.TabPage Bot;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridViewParser;
        private System.Windows.Forms.Timer timerReloadParse;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ask;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.ComboBox comboBoxExchange;
    }
}

