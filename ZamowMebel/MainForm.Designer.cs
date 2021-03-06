﻿namespace ZamowMebel
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
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.konfiguracjaTab = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            zmienOknoLabel = new System.Windows.Forms.Label();
            oknaCB = new System.Windows.Forms.ComboBox();
            this.logowanieRibbonButton = new System.Windows.Forms.RibbonButton();
            this.zamknijRibbonButton = new System.Windows.Forms.RibbonButton();
            this.zamowieniaRibbonButton = new System.Windows.Forms.RibbonButton();
            this.reklamacjeRibbonButton = new System.Windows.Forms.RibbonButton();
            this.operatorzyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.statusyRibbonButton = new System.Windows.Forms.RibbonButton();
            this.dzialyRibbonButton = new System.Windows.Forms.RibbonButton();
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
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Ogólne";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.logowanieRibbonButton);
            this.ribbonPanel1.Items.Add(this.zamknijRibbonButton);
            this.ribbonPanel1.Text = "System";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.zamowieniaRibbonButton);
            this.ribbonPanel3.Items.Add(this.reklamacjeRibbonButton);
            this.ribbonPanel3.Text = "Zamówienia";
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
            // zmienOknoLabel
            // 
            zmienOknoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            zmienOknoLabel.AutoSize = true;
            zmienOknoLabel.Location = new System.Drawing.Point(335, 15);
            zmienOknoLabel.Name = "zmienOknoLabel";
            zmienOknoLabel.Size = new System.Drawing.Size(63, 13);
            zmienOknoLabel.TabIndex = 7;
            zmienOknoLabel.Text = "Zmień okno";
            zmienOknoLabel.Visible = false;
            // 
            // oknaCB
            // 
            oknaCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            oknaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            oknaCB.FormattingEnabled = true;
            oknaCB.Location = new System.Drawing.Point(404, 12);
            oknaCB.Name = "oknaCB";
            oknaCB.Size = new System.Drawing.Size(180, 21);
            oknaCB.TabIndex = 6;
            oknaCB.Visible = false;
            oknaCB.SelectedIndexChanged += new System.EventHandler(oknaCB_SelectedIndexChanged);
            // 
            // logowanieRibbonButton
            // 
            this.logowanieRibbonButton.Image = global::ZamowMebel.Properties.Resources.Grey_gradient;
            this.logowanieRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("logowanieRibbonButton.SmallImage")));
            this.logowanieRibbonButton.Text = "Logowanie";
            this.logowanieRibbonButton.Click += new System.EventHandler(this.logowanieRibbonButton_Click);
            // 
            // zamknijRibbonButton
            // 
            this.zamknijRibbonButton.Image = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.zamknijRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("zamknijRibbonButton.SmallImage")));
            this.zamknijRibbonButton.Text = "Zamknij";
            // 
            // zamowieniaRibbonButton
            // 
            this.zamowieniaRibbonButton.Image = global::ZamowMebel.Properties.Resources.Grey_gradient;
            this.zamowieniaRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("zamowieniaRibbonButton.SmallImage")));
            this.zamowieniaRibbonButton.Text = "Zamówienia";
            this.zamowieniaRibbonButton.Click += new System.EventHandler(this.zamowieniaRibbonButton_Click);
            // 
            // reklamacjeRibbonButton
            // 
            this.reklamacjeRibbonButton.Image = global::ZamowMebel.Properties.Resources.Grey_gradient;
            this.reklamacjeRibbonButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("reklamacjeRibbonButton.SmallImage")));
            this.reklamacjeRibbonButton.Text = "Reklamacje";
            this.reklamacjeRibbonButton.Click += new System.EventHandler(this.reklamacjeRibbonButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(zmienOknoLabel);
            this.Controls.Add(oknaCB);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamów mebel";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
        private System.Windows.Forms.RibbonButton dzialyRibbonButton;
        private System.Windows.Forms.RibbonButton logowanieRibbonButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton zamowieniaRibbonButton;
        private System.Windows.Forms.RibbonButton zamknijRibbonButton;
        private System.Windows.Forms.RibbonButton reklamacjeRibbonButton;
        private static System.Windows.Forms.Label zmienOknoLabel;
        private static System.Windows.Forms.ComboBox oknaCB;
    }
}