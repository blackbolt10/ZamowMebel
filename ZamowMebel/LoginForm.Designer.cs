namespace ZamowMebel
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logOutButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.hasloLabel = new System.Windows.Forms.Label();
            this.operatorCB = new System.Windows.Forms.ComboBox();
            this.hasloTB = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.meblePuszPB = new System.Windows.Forms.PictureBox();
            this.optimaPB = new System.Windows.Forms.PictureBox();
            this.galsoftPB = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.wersjaTSSL = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.meblePuszPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galsoftPB)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.Location = new System.Drawing.Point(18, 241);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(116, 48);
            this.logOutButton.TabIndex = 4;
            this.logOutButton.Text = "Zamknij";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel.Location = new System.Drawing.Point(12, 151);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(83, 31);
            this.loginLabel.TabIndex = 4;
            this.loginLabel.Text = "Login:";
            // 
            // hasloLabel
            // 
            this.hasloLabel.AutoSize = true;
            this.hasloLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloLabel.Location = new System.Drawing.Point(12, 196);
            this.hasloLabel.Name = "hasloLabel";
            this.hasloLabel.Size = new System.Drawing.Size(83, 31);
            this.hasloLabel.TabIndex = 5;
            this.hasloLabel.Text = "Hasło:";
            // 
            // operatorCB
            // 
            this.operatorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operatorCB.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.operatorCB.FormattingEnabled = true;
            this.operatorCB.Location = new System.Drawing.Point(101, 148);
            this.operatorCB.Name = "operatorCB";
            this.operatorCB.Size = new System.Drawing.Size(217, 39);
            this.operatorCB.TabIndex = 1;
            this.operatorCB.SelectedIndexChanged += new System.EventHandler(this.operatorCB_SelectedIndexChanged);
            // 
            // hasloTB
            // 
            this.hasloTB.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTB.Location = new System.Drawing.Point(101, 193);
            this.hasloTB.Name = "hasloTB";
            this.hasloTB.PasswordChar = '*';
            this.hasloTB.Size = new System.Drawing.Size(217, 39);
            this.hasloTB.TabIndex = 2;
            this.hasloTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hasloTB_KeyDown);
            // 
            // logInButton
            // 
            this.logInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logInButton.BackColor = System.Drawing.Color.Lavender;
            this.logInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInButton.Location = new System.Drawing.Point(211, 241);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(109, 48);
            this.logInButton.TabIndex = 3;
            this.logInButton.Text = "Zaloguj";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // meblePuszPB
            // 
            this.meblePuszPB.BackgroundImage = global::ZamowMebel.Properties.Resources.MeblePusz_logo_mini;
            this.meblePuszPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.meblePuszPB.Location = new System.Drawing.Point(12, 59);
            this.meblePuszPB.Name = "meblePuszPB";
            this.meblePuszPB.Size = new System.Drawing.Size(308, 66);
            this.meblePuszPB.TabIndex = 3;
            this.meblePuszPB.TabStop = false;
            // 
            // optimaPB
            // 
            this.optimaPB.BackgroundImage = global::ZamowMebel.Properties.Resources.Comarch_ERP_Optima;
            this.optimaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.optimaPB.Location = new System.Drawing.Point(12, 12);
            this.optimaPB.Name = "optimaPB";
            this.optimaPB.Size = new System.Drawing.Size(124, 41);
            this.optimaPB.TabIndex = 2;
            this.optimaPB.TabStop = false;
            // 
            // galsoftPB
            // 
            this.galsoftPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.galsoftPB.BackgroundImage = global::ZamowMebel.Properties.Resources.Galsoft_logo;
            this.galsoftPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.galsoftPB.Location = new System.Drawing.Point(188, 12);
            this.galsoftPB.Name = "galsoftPB";
            this.galsoftPB.Size = new System.Drawing.Size(132, 41);
            this.galsoftPB.TabIndex = 1;
            this.galsoftPB.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ZamowMebel.Properties.Resources.login;
            this.button3.Location = new System.Drawing.Point(135, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Force LogIn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wersjaTSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(328, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // wersjaTSSL
            // 
            this.wersjaTSSL.Name = "wersjaTSSL";
            this.wersjaTSSL.Size = new System.Drawing.Size(69, 17);
            this.wersjaTSSL.Text = "Wersja X.XX";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(328, 319);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.hasloTB);
            this.Controls.Add(this.operatorCB);
            this.Controls.Add(this.hasloLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.meblePuszPB);
            this.Controls.Add(this.optimaPB);
            this.Controls.Add(this.galsoftPB);
            this.Controls.Add(this.logOutButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZamówMebel - Logowanie";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.meblePuszPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galsoftPB)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.PictureBox galsoftPB;
        private System.Windows.Forms.PictureBox optimaPB;
        private System.Windows.Forms.PictureBox meblePuszPB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label hasloLabel;
        private System.Windows.Forms.ComboBox operatorCB;
        private System.Windows.Forms.TextBox hasloTB;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel wersjaTSSL;
    }
}

