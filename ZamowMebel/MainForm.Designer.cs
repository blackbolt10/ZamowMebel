namespace ZamowMebel
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.konfiguracjaTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.operatorzyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.statusyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.dzialyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.zmienOknoLabel = new System.Windows.Forms.Label();
            this.oknaCB = new System.Windows.Forms.ComboBox();
            this.logowanieRibbonButton = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbVisible = false;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Visible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(584, 120);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.konfiguracjaTab);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(1, 5, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.logowanieRibbonButton);
            this.ribbonPanel1.Text = "System";
            // 
            // konfiguracjaTab
            // 
            this.konfiguracjaTab.Panels.Add(this.ribbonPanel2);
            this.konfiguracjaTab.Text = "Konfiguracja";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.operatorzyRibbonButton);
            this.ribbonPanel2.Items.Add(this.statusyRibbonButton);
            this.ribbonPanel2.Items.Add(this.dzialyRibbonButton);
            this.ribbonPanel2.Text = "Ustawienia";
            // 
            // operatorzyRibbonButton
            // 
            this.operatorzyRibbonButton.Image = global::ZamowMebel.Properties.Resources.Klienci_ustawienia_32x32;
            this.operatorzyRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("operatorzyRibbonButton.SmallImage")));
            this.operatorzyRibbonButton.Text = "Operatorzy";
            this.operatorzyRibbonButton.Click += new System.EventHandler(this.operatorzyRibbonButton_Click);
            // 
            // statusyRibbonButton
            // 
            this.statusyRibbonButton.Image = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.statusyRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("statusyRibbonButton.SmallImage")));
            this.statusyRibbonButton.Text = "Statusy";
            this.statusyRibbonButton.Click += new System.EventHandler(this.statusyRibbonButton_Click);
            // 
            // dzialyRibbonButton
            // 
            this.dzialyRibbonButton.Image = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.dzialyRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("dzialyRibbonButton.SmallImage")));
            this.dzialyRibbonButton.Text = "Działy";
            this.dzialyRibbonButton.Click += new System.EventHandler(this.dzialyRibbonButton_Click);
            // 
            // zmienOknoLabel
            // 
            this.zmienOknoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zmienOknoLabel.AutoSize = true;
            this.zmienOknoLabel.Location = new System.Drawing.Point(335, 15);
            this.zmienOknoLabel.Name = "zmienOknoLabel";
            this.zmienOknoLabel.Size = new System.Drawing.Size(63, 13);
            this.zmienOknoLabel.TabIndex = 7;
            this.zmienOknoLabel.Text = "Zmień okno";
            this.zmienOknoLabel.Visible = false;
            // 
            // oknaCB
            // 
            this.oknaCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oknaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oknaCB.FormattingEnabled = true;
            this.oknaCB.Location = new System.Drawing.Point(404, 12);
            this.oknaCB.Name = "oknaCB";
            this.oknaCB.Size = new System.Drawing.Size(180, 21);
            this.oknaCB.TabIndex = 6;
            this.oknaCB.Visible = false;
            this.oknaCB.SelectedIndexChanged += new System.EventHandler(this.oknaCB_SelectedIndexChanged);
            // 
            // logowanieRibbonButton
            // 
            this.logowanieRibbonButton.Image = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.logowanieRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("logowanieRibbonButton.SmallImage")));
            this.logowanieRibbonButton.Text = "Logowanie";
            this.logowanieRibbonButton.Click += new System.EventHandler(this.logowanieRibbonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.zmienOknoLabel);
            this.Controls.Add(this.oknaCB);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamów mebel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab konfiguracjaTab;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton operatorzyRibbonButton;
        private System.Windows.Forms.RibbonButton statusyRibbonButton;
        private System.Windows.Forms.Label zmienOknoLabel;
        private System.Windows.Forms.ComboBox oknaCB;
        private System.Windows.Forms.RibbonButton dzialyRibbonButton;
        private System.Windows.Forms.RibbonButton logowanieRibbonButton;
    }
}