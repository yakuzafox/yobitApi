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
            this.toolStripMenuParser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPair = new System.Windows.Forms.ListBox();
            this.labelSelectedPair = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxUSDT = new System.Windows.Forms.CheckBox();
            this.checkBoxRUR = new System.Windows.Forms.CheckBox();
            this.checkBoxUSD = new System.Windows.Forms.CheckBox();
            this.checkBoxW = new System.Windows.Forms.CheckBox();
            this.checkBoxYO = new System.Windows.Forms.CheckBox();
            this.checkBoxDOGE = new System.Windows.Forms.CheckBox();
            this.checkBoxETH = new System.Windows.Forms.CheckBox();
            this.checkBoxBTC = new System.Windows.Forms.CheckBox();
            this.textBoxSearchPair = new System.Windows.Forms.TextBox();
            this.menuStripMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuParser,
            this.toolStripMenuHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(915, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // toolStripMenuParser
            // 
            this.toolStripMenuParser.Name = "toolStripMenuParser";
            this.toolStripMenuParser.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuParser.Text = "Parser";
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuHelp.Text = "Help";
            // 
            // listBoxPair
            // 
            this.listBoxPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPair.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPair.FormattingEnabled = true;
            this.listBoxPair.ItemHeight = 23;
            this.listBoxPair.Location = new System.Drawing.Point(12, 138);
            this.listBoxPair.Name = "listBoxPair";
            this.listBoxPair.Size = new System.Drawing.Size(222, 349);
            this.listBoxPair.TabIndex = 1;
            this.listBoxPair.SelectedIndexChanged += new System.EventHandler(this.listBoxPair_SelectedIndexChanged);
            // 
            // labelSelectedPair
            // 
            this.labelSelectedPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSelectedPair.AutoSize = true;
            this.labelSelectedPair.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelSelectedPair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedPair.Location = new System.Drawing.Point(12, 50);
            this.labelSelectedPair.Name = "labelSelectedPair";
            this.labelSelectedPair.Size = new System.Drawing.Size(118, 28);
            this.labelSelectedPair.TabIndex = 2;
            this.labelSelectedPair.Text = "SelectedPair";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUSDT);
            this.groupBox1.Controls.Add(this.checkBoxRUR);
            this.groupBox1.Controls.Add(this.checkBoxUSD);
            this.groupBox1.Controls.Add(this.checkBoxW);
            this.groupBox1.Controls.Add(this.checkBoxYO);
            this.groupBox1.Controls.Add(this.checkBoxDOGE);
            this.groupBox1.Controls.Add(this.checkBoxETH);
            this.groupBox1.Controls.Add(this.checkBoxBTC);
            this.groupBox1.Location = new System.Drawing.Point(280, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxUSDT
            // 
            this.checkBoxUSDT.AutoSize = true;
            this.checkBoxUSDT.Location = new System.Drawing.Point(445, 22);
            this.checkBoxUSDT.Name = "checkBoxUSDT";
            this.checkBoxUSDT.Size = new System.Drawing.Size(67, 24);
            this.checkBoxUSDT.TabIndex = 0;
            this.checkBoxUSDT.Text = "USDT";
            this.checkBoxUSDT.UseVisualStyleBackColor = true;
            // 
            // checkBoxRUR
            // 
            this.checkBoxRUR.AutoSize = true;
            this.checkBoxRUR.Location = new System.Drawing.Point(380, 22);
            this.checkBoxRUR.Name = "checkBoxRUR";
            this.checkBoxRUR.Size = new System.Drawing.Size(59, 24);
            this.checkBoxRUR.TabIndex = 0;
            this.checkBoxRUR.Text = "RUR";
            this.checkBoxRUR.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSD
            // 
            this.checkBoxUSD.AutoSize = true;
            this.checkBoxUSD.Location = new System.Drawing.Point(314, 22);
            this.checkBoxUSD.Name = "checkBoxUSD";
            this.checkBoxUSD.Size = new System.Drawing.Size(60, 24);
            this.checkBoxUSD.TabIndex = 0;
            this.checkBoxUSD.Text = "USD";
            this.checkBoxUSD.UseVisualStyleBackColor = true;
            // 
            // checkBoxW
            // 
            this.checkBoxW.AutoSize = true;
            this.checkBoxW.Location = new System.Drawing.Point(263, 22);
            this.checkBoxW.Name = "checkBoxW";
            this.checkBoxW.Size = new System.Drawing.Size(45, 24);
            this.checkBoxW.TabIndex = 0;
            this.checkBoxW.Text = "W";
            this.checkBoxW.UseVisualStyleBackColor = true;
            // 
            // checkBoxYO
            // 
            this.checkBoxYO.AutoSize = true;
            this.checkBoxYO.Location = new System.Drawing.Point(208, 22);
            this.checkBoxYO.Name = "checkBoxYO";
            this.checkBoxYO.Size = new System.Drawing.Size(49, 24);
            this.checkBoxYO.TabIndex = 0;
            this.checkBoxYO.Text = "YO";
            this.checkBoxYO.UseVisualStyleBackColor = true;
            // 
            // checkBoxDOGE
            // 
            this.checkBoxDOGE.AutoSize = true;
            this.checkBoxDOGE.Location = new System.Drawing.Point(131, 22);
            this.checkBoxDOGE.Name = "checkBoxDOGE";
            this.checkBoxDOGE.Size = new System.Drawing.Size(71, 24);
            this.checkBoxDOGE.TabIndex = 0;
            this.checkBoxDOGE.Text = "DOGE";
            this.checkBoxDOGE.UseVisualStyleBackColor = true;
            // 
            // checkBoxETH
            // 
            this.checkBoxETH.AutoSize = true;
            this.checkBoxETH.Location = new System.Drawing.Point(67, 22);
            this.checkBoxETH.Name = "checkBoxETH";
            this.checkBoxETH.Size = new System.Drawing.Size(58, 24);
            this.checkBoxETH.TabIndex = 0;
            this.checkBoxETH.Text = "ETH";
            this.checkBoxETH.UseVisualStyleBackColor = true;
            // 
            // checkBoxBTC
            // 
            this.checkBoxBTC.AutoSize = true;
            this.checkBoxBTC.Location = new System.Drawing.Point(6, 22);
            this.checkBoxBTC.Name = "checkBoxBTC";
            this.checkBoxBTC.Size = new System.Drawing.Size(55, 24);
            this.checkBoxBTC.TabIndex = 0;
            this.checkBoxBTC.Text = "BTC";
            this.checkBoxBTC.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPair
            // 
            this.textBoxSearchPair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSearchPair.Location = new System.Drawing.Point(13, 102);
            this.textBoxSearchPair.Name = "textBoxSearchPair";
            this.textBoxSearchPair.PlaceholderText = "Search";
            this.textBoxSearchPair.Size = new System.Drawing.Size(221, 27);
            this.textBoxSearchPair.TabIndex = 4;
            this.textBoxSearchPair.TextChanged += new System.EventHandler(this.textBoxSearchPair_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 526);
            this.Controls.Add(this.textBoxSearchPair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSelectedPair);
            this.Controls.Add(this.listBoxPair);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "ApiClientYobit";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuParser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.ListBox listBoxPair;
        private System.Windows.Forms.Label labelSelectedPair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxUSDT;
        private System.Windows.Forms.CheckBox checkBoxRUR;
        private System.Windows.Forms.CheckBox checkBoxUSD;
        private System.Windows.Forms.CheckBox checkBoxW;
        private System.Windows.Forms.CheckBox checkBoxYO;
        private System.Windows.Forms.CheckBox checkBoxDOGE;
        private System.Windows.Forms.CheckBox checkBoxETH;
        private System.Windows.Forms.CheckBox checkBoxBTC;
        private System.Windows.Forms.TextBox textBoxSearchPair;
    }
}

