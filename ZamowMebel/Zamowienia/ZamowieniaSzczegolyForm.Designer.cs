namespace ZamowMebel.Zamowienia
{
    partial class ZamowieniaSzczegolyForm
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
            this.kontrahentaDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataWystL = new System.Windows.Forms.Label();
            this.dataRezerwL = new System.Windows.Forms.Label();
            this.pozycjeDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.komentarzRTB = new System.Windows.Forms.RichTextBox();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentaDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // kontrahentaDGV
            // 
            this.kontrahentaDGV.AllowUserToAddRows = false;
            this.kontrahentaDGV.AllowUserToDeleteRows = false;
            this.kontrahentaDGV.AllowUserToResizeRows = false;
            this.kontrahentaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.kontrahentaDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kontrahentaDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.kontrahentaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kontrahentaDGV.Location = new System.Drawing.Point(15, 25);
            this.kontrahentaDGV.MultiSelect = false;
            this.kontrahentaDGV.Name = "kontrahentaDGV";
            this.kontrahentaDGV.ReadOnly = true;
            this.kontrahentaDGV.RowHeadersVisible = false;
            this.kontrahentaDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kontrahentaDGV.Size = new System.Drawing.Size(193, 82);
            this.kontrahentaDGV.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Kontrahent:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Data wystawienia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Data rezerwacji:";
            // 
            // dataWystL
            // 
            this.dataWystL.AutoSize = true;
            this.dataWystL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataWystL.Location = new System.Drawing.Point(214, 27);
            this.dataWystL.Name = "dataWystL";
            this.dataWystL.Size = new System.Drawing.Size(100, 17);
            this.dataWystL.TabIndex = 113;
            this.dataWystL.Text = "XX-XX-XXXX";
            // 
            // dataRezerwL
            // 
            this.dataRezerwL.AutoSize = true;
            this.dataRezerwL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataRezerwL.Location = new System.Drawing.Point(214, 70);
            this.dataRezerwL.Name = "dataRezerwL";
            this.dataRezerwL.Size = new System.Drawing.Size(100, 17);
            this.dataRezerwL.TabIndex = 114;
            this.dataRezerwL.Text = "XX-XX-XXXX";
            // 
            // pozycjeDGV
            // 
            this.pozycjeDGV.AllowUserToAddRows = false;
            this.pozycjeDGV.AllowUserToDeleteRows = false;
            this.pozycjeDGV.AllowUserToResizeRows = false;
            this.pozycjeDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pozycjeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pozycjeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pozycjeDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.pozycjeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pozycjeDGV.Location = new System.Drawing.Point(15, 126);
            this.pozycjeDGV.MultiSelect = false;
            this.pozycjeDGV.Name = "pozycjeDGV";
            this.pozycjeDGV.ReadOnly = true;
            this.pozycjeDGV.RowHeadersVisible = false;
            this.pozycjeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pozycjeDGV.Size = new System.Drawing.Size(573, 224);
            this.pozycjeDGV.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Pozycje:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "Komentarz";
            // 
            // komentarzRTB
            // 
            this.komentarzRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.komentarzRTB.Location = new System.Drawing.Point(320, 27);
            this.komentarzRTB.MaxLength = 1000;
            this.komentarzRTB.Name = "komentarzRTB";
            this.komentarzRTB.Size = new System.Drawing.Size(268, 80);
            this.komentarzRTB.TabIndex = 118;
            this.komentarzRTB.Text = "";
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.BackgroundImage = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.zamknijButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijButton.Location = new System.Drawing.Point(556, 356);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(32, 32);
            this.zamknijButton.TabIndex = 119;
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 120;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ZamowieniaSzczegolyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.komentarzRTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pozycjeDGV);
            this.Controls.Add(this.dataRezerwL);
            this.Controls.Add(this.dataWystL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kontrahentaDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZamowieniaSzczegolyForm";
            this.Text = "ZamowieniaSzczegolyForm";
            ((System.ComponentModel.ISupportInitialize)(this.kontrahentaDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozycjeDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kontrahentaDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataWystL;
        private System.Windows.Forms.Label dataRezerwL;
        private System.Windows.Forms.DataGridView pozycjeDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox komentarzRTB;
        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.Button button1;
    }
}