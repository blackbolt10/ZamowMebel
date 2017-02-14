namespace ZamowMebel.Konfiguracja.Ustawienia.Dzialy
{
    partial class DzialyForm
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
            this.dzialyDGV = new System.Windows.Forms.DataGridView();
            this.archiwalneCHB = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dzialyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dzialyDGV
            // 
            this.dzialyDGV.AllowUserToAddRows = false;
            this.dzialyDGV.AllowUserToDeleteRows = false;
            this.dzialyDGV.AllowUserToResizeRows = false;
            this.dzialyDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dzialyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dzialyDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dzialyDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dzialyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dzialyDGV.Location = new System.Drawing.Point(12, 12);
            this.dzialyDGV.MultiSelect = false;
            this.dzialyDGV.Name = "dzialyDGV";
            this.dzialyDGV.ReadOnly = true;
            this.dzialyDGV.RowHeadersVisible = false;
            this.dzialyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dzialyDGV.Size = new System.Drawing.Size(576, 338);
            this.dzialyDGV.TabIndex = 108;
            // 
            // archiwalneCHB
            // 
            this.archiwalneCHB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.archiwalneCHB.AutoSize = true;
            this.archiwalneCHB.Location = new System.Drawing.Point(12, 365);
            this.archiwalneCHB.Name = "archiwalneCHB";
            this.archiwalneCHB.Size = new System.Drawing.Size(110, 17);
            this.archiwalneCHB.TabIndex = 103;
            this.archiwalneCHB.Text = "Pokaż archiwalne";
            this.archiwalneCHB.UseVisualStyleBackColor = true;
            this.archiwalneCHB.CheckedChanged += new System.EventHandler(this.archiwalneCHB_CheckedChanged);
            this.archiwalneCHB.Click += new System.EventHandler(this.archiwalneCHB_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackgroundImage = global::ZamowMebel.Properties.Resources.dodaj;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.Location = new System.Drawing.Point(442, 356);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(32, 32);
            this.addButton.TabIndex = 104;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.BackgroundImage = global::ZamowMebel.Properties.Resources.zmien;
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeButton.Location = new System.Drawing.Point(480, 356);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(32, 32);
            this.changeButton.TabIndex = 105;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.BackgroundImage = global::ZamowMebel.Properties.Resources.usun;
            this.delButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delButton.Location = new System.Drawing.Point(518, 356);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(32, 32);
            this.delButton.TabIndex = 106;
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.BackgroundImage = global::ZamowMebel.Properties.Resources.koniec_32x32;
            this.zamknijButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.zamknijButton.Location = new System.Drawing.Point(556, 356);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(32, 32);
            this.zamknijButton.TabIndex = 107;
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // DzialyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dzialyDGV);
            this.Controls.Add(this.archiwalneCHB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.zamknijButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DzialyForm";
            this.Text = "DzialyForm";
            ((System.ComponentModel.ISupportInitialize)(this.dzialyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dzialyDGV;
        private System.Windows.Forms.CheckBox archiwalneCHB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button zamknijButton;
    }
}