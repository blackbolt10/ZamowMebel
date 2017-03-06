namespace ZamowMebel.Zamowienia.Reklamacje
{
    partial class ReklamacjeChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReklamacjeChangeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.opisRTB = new System.Windows.Forms.RichTextBox();
            this.nrTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kontrahentTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kontrahentButton = new System.Windows.Forms.Button();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reklamacja nr. ";
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(58, 187);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(182, 21);
            this.statusCB.TabIndex = 1;
            // 
            // opisRTB
            // 
            this.opisRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opisRTB.Location = new System.Drawing.Point(15, 70);
            this.opisRTB.Name = "opisRTB";
            this.opisRTB.Size = new System.Drawing.Size(563, 111);
            this.opisRTB.TabIndex = 2;
            this.opisRTB.Text = "";
            // 
            // nrTB
            // 
            this.nrTB.Location = new System.Drawing.Point(15, 25);
            this.nrTB.Name = "nrTB";
            this.nrTB.Size = new System.Drawing.Size(94, 20);
            this.nrTB.TabIndex = 3;
            this.nrTB.Text = "2015/1000";
            this.nrTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kontrahent";
            // 
            // kontrahentTB
            // 
            this.kontrahentTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kontrahentTB.Location = new System.Drawing.Point(141, 25);
            this.kontrahentTB.Name = "kontrahentTB";
            this.kontrahentTB.Size = new System.Drawing.Size(355, 20);
            this.kontrahentTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // kontrahentButton
            // 
            this.kontrahentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kontrahentButton.Location = new System.Drawing.Point(503, 12);
            this.kontrahentButton.Name = "kontrahentButton";
            this.kontrahentButton.Size = new System.Drawing.Size(75, 42);
            this.kontrahentButton.TabIndex = 8;
            this.kontrahentButton.Text = "Pobierz z Optimy";
            this.kontrahentButton.UseVisualStyleBackColor = true;
            this.kontrahentButton.Click += new System.EventHandler(this.kontrahentButton_Click);
            // 
            // zapiszButton
            // 
            this.zapiszButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zapiszButton.Location = new System.Drawing.Point(416, 190);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 9;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.Location = new System.Drawing.Point(497, 190);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(75, 23);
            this.zamknijButton.TabIndex = 10;
            this.zamknijButton.Text = "Zamknij";
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // ReklamacjeChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 219);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.kontrahentButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kontrahentTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nrTB);
            this.Controls.Add(this.opisRTB);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReklamacjeChangeForm";
            this.Text = "Dodaj reklamację";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.RichTextBox opisRTB;
        private System.Windows.Forms.TextBox nrTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kontrahentTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kontrahentButton;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button zamknijButton;
    }
}