﻿namespace ZamowMebel.Konfiguracja.Ustawienia.Dzialy
{
    partial class DzialyChangeForm
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
            this.archiwalnyCB = new System.Windows.Forms.CheckBox();
            this.nazwaTB = new System.Windows.Forms.TextBox();
            this.nazwaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zamknijButton
            // 
            this.zamknijButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zamknijButton.Location = new System.Drawing.Point(197, 53);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(75, 23);
            this.zamknijButton.TabIndex = 25;
            this.zamknijButton.Text = "&Anuluj";
            this.zamknijButton.UseVisualStyleBackColor = true;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // akceptujButton
            // 
            this.akceptujButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.akceptujButton.Location = new System.Drawing.Point(116, 53);
            this.akceptujButton.Name = "akceptujButton";
            this.akceptujButton.Size = new System.Drawing.Size(75, 23);
            this.akceptujButton.TabIndex = 24;
            this.akceptujButton.Text = "&Zapisz";
            this.akceptujButton.UseVisualStyleBackColor = true;
            this.akceptujButton.Click += new System.EventHandler(this.akceptujButton_Click);
            // 
            // archiwalnyCB
            // 
            this.archiwalnyCB.AutoSize = true;
            this.archiwalnyCB.Location = new System.Drawing.Point(15, 38);
            this.archiwalnyCB.Name = "archiwalnyCB";
            this.archiwalnyCB.Size = new System.Drawing.Size(77, 17);
            this.archiwalnyCB.TabIndex = 23;
            this.archiwalnyCB.Text = "Archiwalny";
            this.archiwalnyCB.UseVisualStyleBackColor = true;
            // 
            // nazwaTB
            // 
            this.nazwaTB.Location = new System.Drawing.Point(87, 12);
            this.nazwaTB.Name = "nazwaTB";
            this.nazwaTB.Size = new System.Drawing.Size(185, 20);
            this.nazwaTB.TabIndex = 22;
            // 
            // nazwaLabel
            // 
            this.nazwaLabel.AutoSize = true;
            this.nazwaLabel.Location = new System.Drawing.Point(12, 15);
            this.nazwaLabel.Name = "nazwaLabel";
            this.nazwaLabel.Size = new System.Drawing.Size(43, 13);
            this.nazwaLabel.TabIndex = 21;
            this.nazwaLabel.Text = "Nazwa:";
            // 
            // DzialyChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.akceptujButton);
            this.Controls.Add(this.archiwalnyCB);
            this.Controls.Add(this.nazwaTB);
            this.Controls.Add(this.nazwaLabel);
            this.Name = "DzialyChangeForm";
            this.Text = "Nowy dział";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zamknijButton;
        private System.Windows.Forms.Button akceptujButton;
        private System.Windows.Forms.CheckBox archiwalnyCB;
        private System.Windows.Forms.TextBox nazwaTB;
        private System.Windows.Forms.Label nazwaLabel;
    }
}