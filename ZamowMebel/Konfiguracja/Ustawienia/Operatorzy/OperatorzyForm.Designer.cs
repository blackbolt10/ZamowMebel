namespace ZamowMebel.Konfiguracja.Ustawienia.Operatorzy
{
    partial class OperatorzyForm
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
            this.operatorzyDGV = new System.Windows.Forms.DataGridView();
            this.archiwalniCHB = new System.Windows.Forms.CheckBox();
            this.unlockButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operatorzyDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // operatorzyDGV
            // 
            this.operatorzyDGV.AllowUserToAddRows = false;
            this.operatorzyDGV.AllowUserToDeleteRows = false;
            this.operatorzyDGV.AllowUserToResizeRows = false;
            this.operatorzyDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operatorzyDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.operatorzyDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.operatorzyDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.operatorzyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorzyDGV.Location = new System.Drawing.Point(12, 12);
            this.operatorzyDGV.MultiSelect = false;
            this.operatorzyDGV.Name = "operatorzyDGV";
            this.operatorzyDGV.ReadOnly = true;
            this.operatorzyDGV.RowHeadersVisible = false;
            this.operatorzyDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operatorzyDGV.Size = new System.Drawing.Size(576, 338);
            this.operatorzyDGV.TabIndex = 104;
            // 
            // archiwalniCHB
            // 
            this.archiwalniCHB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.archiwalniCHB.AutoSize = true;
            this.archiwalniCHB.Location = new System.Drawing.Point(12, 365);
            this.archiwalniCHB.Name = "archiwalniCHB";
            this.archiwalniCHB.Size = new System.Drawing.Size(121, 17);
            this.archiwalniCHB.TabIndex = 98;
            this.archiwalniCHB.Text = "Pokaż archiwalnych";
            this.archiwalniCHB.UseVisualStyleBackColor = true;
            this.archiwalniCHB.CheckedChanged += new System.EventHandler(this.archiwalniCHB_CheckedChanged);
            // 
            // unlockButton
            // 
            this.unlockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unlockButton.BackgroundImage = global::ZamowMebel.Properties.Resources.unlock;
            this.unlockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.unlockButton.Enabled = false;
            this.unlockButton.Location = new System.Drawing.Point(139, 356);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(32, 32);
            this.unlockButton.TabIndex = 103;
            this.unlockButton.UseVisualStyleBackColor = true;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackgroundImage = global::ZamowMebel.Properties.Resources.dodaj;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addButton.Location = new System.Drawing.Point(442, 356);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(32, 32);
            this.addButton.TabIndex = 99;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeButton.BackgroundImage = global::ZamowMebel.Properties.Resources.zmien;
            this.changeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changeButton.Location = new System.Drawing.Point(480, 356);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(32, 32);
            this.changeButton.TabIndex = 100;
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // delButton
            // 
            this.delButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delButton.BackgroundImage = global::ZamowMebel.Properties.Resources.usun;
            this.delButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delButton.Location = new System.Drawing.Point(518, 356);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(32, 32);
            this.delButton.TabIndex = 101;
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
            this.zamknijButton.TabIndex = 102;
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // OperatorzyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.operatorzyDGV);
            this.Controls.Add(this.unlockButton);
            this.Controls.Add(this.archiwalniCHB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.zamknijButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OperatorzyForm";
            this.Text = "Operatorzy - ustawienia";
            ((System.ComponentModel.ISupportInitialize)(this.operatorzyDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView operatorzyDGV;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.CheckBox archiwalniCHB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button zamknijButton;
    }
}