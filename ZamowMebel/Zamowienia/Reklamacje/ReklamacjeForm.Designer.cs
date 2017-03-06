namespace ZamowMebel.Zamowienia.Reklamacje
{
    partial class ReklamacjeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataDoDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataOdDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.kontrahenciCB = new System.Windows.Forms.ComboBox();
            this.reklamacjeDGV = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.reloadButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dataDoDTP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.statusCB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataOdDTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kontrahenciCB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 78);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data do:";
            // 
            // dataDoDTP
            // 
            this.dataDoDTP.Location = new System.Drawing.Point(308, 45);
            this.dataDoDTP.Name = "dataDoDTP";
            this.dataDoDTP.Size = new System.Drawing.Size(138, 20);
            this.dataDoDTP.TabIndex = 6;
            this.dataDoDTP.ValueChanged += new System.EventHandler(this.dataDoDTP_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status:";
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(74, 46);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(169, 21);
            this.statusCB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data od:";
            // 
            // dataOdDTP
            // 
            this.dataOdDTP.Location = new System.Drawing.Point(308, 19);
            this.dataOdDTP.Name = "dataOdDTP";
            this.dataOdDTP.Size = new System.Drawing.Size(138, 20);
            this.dataOdDTP.TabIndex = 2;
            this.dataOdDTP.ValueChanged += new System.EventHandler(this.dataOdDTP_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kontrahent:";
            // 
            // kontrahenciCB
            // 
            this.kontrahenciCB.FormattingEnabled = true;
            this.kontrahenciCB.Location = new System.Drawing.Point(74, 19);
            this.kontrahenciCB.Name = "kontrahenciCB";
            this.kontrahenciCB.Size = new System.Drawing.Size(169, 21);
            this.kontrahenciCB.TabIndex = 0;
            // 
            // reklamacjeDGV
            // 
            this.reklamacjeDGV.AllowUserToAddRows = false;
            this.reklamacjeDGV.AllowUserToDeleteRows = false;
            this.reklamacjeDGV.AllowUserToResizeRows = false;
            this.reklamacjeDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reklamacjeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.reklamacjeDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reklamacjeDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.reklamacjeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reklamacjeDGV.Location = new System.Drawing.Point(12, 12);
            this.reklamacjeDGV.MultiSelect = false;
            this.reklamacjeDGV.Name = "reklamacjeDGV";
            this.reklamacjeDGV.ReadOnly = true;
            this.reklamacjeDGV.RowHeadersVisible = false;
            this.reklamacjeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reklamacjeDGV.Size = new System.Drawing.Size(626, 292);
            this.reklamacjeDGV.TabIndex = 118;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackgroundImage = global::ZamowMebel.Properties.Resources.dodaj;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(530, 359);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(32, 32);
            this.addButton.TabIndex = 119;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reloadButton.BackgroundImage = global::ZamowMebel.Properties.Resources.odswiez_32x32;
            this.reloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadButton.Location = new System.Drawing.Point(480, 359);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(32, 32);
            this.reloadButton.TabIndex = 117;
            this.reloadButton.UseVisualStyleBackColor = true;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.BackgroundImage = global::ZamowMebel.Properties.Resources.zmien;
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(568, 359);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(32, 32);
            this.changeButton.TabIndex = 115;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.BackgroundImage = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.zamknijButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijButton.Location = new System.Drawing.Point(606, 359);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(32, 32);
            this.zamknijButton.TabIndex = 116;
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // ReklamacjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.reklamacjeDGV);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReklamacjeForm";
            this.Text = "ReklamacjeForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklamacjeDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataDoDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataOdDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kontrahenciCB;
        private System.Windows.Forms.DataGridView reklamacjeDGV;
        private System.Windows.Forms.Button addButton;
    }
}