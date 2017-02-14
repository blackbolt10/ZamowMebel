namespace ZamowMebel.Konfiguracja.Ustawienia.Operatorzy
{
    partial class OperatorzyChangeForm
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
            this.zamknijButton = new System.Windows.Forms.Button();
            this.akceptujButton = new System.Windows.Forms.Button();
            this.uprawnieniaCB = new System.Windows.Forms.ComboBox();
            this.archiwalnyCB = new System.Windows.Forms.CheckBox();
            this.uprawnieniaLabel = new System.Windows.Forms.Label();
            this.nazwiskoTB = new System.Windows.Forms.TextBox();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieTB = new System.Windows.Forms.TextBox();
            this.imieLabel = new System.Windows.Forms.Label();
            this.dzialCB = new System.Windows.Forms.ComboBox();
            this.dzialLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.Location = new System.Drawing.Point(197, 134);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(75, 23);
            this.zamknijButton.TabIndex = 15;
            this.zamknijButton.Text = "&Anuluj";
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // akceptujButton
            // 
            this.akceptujButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.akceptujButton.Location = new System.Drawing.Point(116, 134);
            this.akceptujButton.Name = "akceptujButton";
            this.akceptujButton.Size = new System.Drawing.Size(75, 23);
            this.akceptujButton.TabIndex = 14;
            this.akceptujButton.Text = "&Zapisz";
            this.akceptujButton.UseVisualStyleBackColor = true;
            this.akceptujButton.Click += new System.EventHandler(this.akceptujButton_Click);
            // 
            // uprawnieniaCB
            // 
            this.uprawnieniaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uprawnieniaCB.FormattingEnabled = true;
            this.uprawnieniaCB.Items.AddRange(new object[] {
            "Wybierz uprawnienia",
            "Administrator",
            "Recepcja",
            "Produkcja"});
            this.uprawnieniaCB.Location = new System.Drawing.Point(87, 89);
            this.uprawnieniaCB.Name = "uprawnieniaCB";
            this.uprawnieniaCB.Size = new System.Drawing.Size(185, 21);
            this.uprawnieniaCB.TabIndex = 11;
            // 
            // archiwalnyCB
            // 
            this.archiwalnyCB.AutoSize = true;
            this.archiwalnyCB.Location = new System.Drawing.Point(15, 116);
            this.archiwalnyCB.Name = "archiwalnyCB";
            this.archiwalnyCB.Size = new System.Drawing.Size(77, 17);
            this.archiwalnyCB.TabIndex = 12;
            this.archiwalnyCB.Text = "Archiwalny";
            this.archiwalnyCB.UseVisualStyleBackColor = true;
            // 
            // uprawnieniaLabel
            // 
            this.uprawnieniaLabel.AutoSize = true;
            this.uprawnieniaLabel.Location = new System.Drawing.Point(12, 92);
            this.uprawnieniaLabel.Name = "uprawnieniaLabel";
            this.uprawnieniaLabel.Size = new System.Drawing.Size(69, 13);
            this.uprawnieniaLabel.TabIndex = 13;
            this.uprawnieniaLabel.Text = "Uprawnienia:";
            // 
            // nazwiskoTB
            // 
            this.nazwiskoTB.Location = new System.Drawing.Point(87, 36);
            this.nazwiskoTB.Name = "nazwiskoTB";
            this.nazwiskoTB.Size = new System.Drawing.Size(185, 20);
            this.nazwiskoTB.TabIndex = 9;
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Location = new System.Drawing.Point(12, 39);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(56, 13);
            this.nazwiskoLabel.TabIndex = 10;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(87, 10);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(185, 20);
            this.imieTB.TabIndex = 8;
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Location = new System.Drawing.Point(12, 13);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(29, 13);
            this.imieLabel.TabIndex = 7;
            this.imieLabel.Text = "Imię:";
            // 
            // dzialCB
            // 
            this.dzialCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dzialCB.FormattingEnabled = true;
            this.dzialCB.Location = new System.Drawing.Point(87, 62);
            this.dzialCB.Name = "dzialCB";
            this.dzialCB.Size = new System.Drawing.Size(185, 21);
            this.dzialCB.TabIndex = 16;
            // 
            // dzialLabel
            // 
            this.dzialLabel.AutoSize = true;
            this.dzialLabel.Location = new System.Drawing.Point(12, 65);
            this.dzialLabel.Name = "dzialLabel";
            this.dzialLabel.Size = new System.Drawing.Size(35, 13);
            this.dzialLabel.TabIndex = 17;
            this.dzialLabel.Text = "Dział:";
            // 
            // OperatorzyChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.Controls.Add(this.dzialCB);
            this.Controls.Add(this.dzialLabel);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.akceptujButton);
            this.Controls.Add(this.uprawnieniaCB);
            this.Controls.Add(this.archiwalnyCB);
            this.Controls.Add(this.uprawnieniaLabel);
            this.Controls.Add(this.nazwiskoTB);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieTB);
            this.Controls.Add(this.imieLabel);
            this.Name = "OperatorzyChangeForm";
            this.Text = "Nowy operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.Button akceptujButton;
        private System.Windows.Forms.ComboBox uprawnieniaCB;
        private System.Windows.Forms.CheckBox archiwalnyCB;
        private System.Windows.Forms.Label uprawnieniaLabel;
        private System.Windows.Forms.TextBox nazwiskoTB;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.TextBox imieTB;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.ComboBox dzialCB;
        private System.Windows.Forms.Label dzialLabel;
    }
}