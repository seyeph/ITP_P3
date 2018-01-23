namespace Blog_Creator
{
    partial class frmSettings
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
            if (disposing && (components != null))
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
            this.cmdCancelSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdSaveSettings = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.lblInfoUsername = new System.Windows.Forms.Label();
            this.lblInfoPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCancelSettings
            // 
            this.cmdCancelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdCancelSettings.Depth = 0;
            this.cmdCancelSettings.Location = new System.Drawing.Point(12, 199);
            this.cmdCancelSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdCancelSettings.Name = "cmdCancelSettings";
            this.cmdCancelSettings.Primary = true;
            this.cmdCancelSettings.Size = new System.Drawing.Size(189, 40);
            this.cmdCancelSettings.TabIndex = 2;
            this.cmdCancelSettings.Text = "Abbrechen";
            this.cmdCancelSettings.UseVisualStyleBackColor = true;
            this.cmdCancelSettings.Click += new System.EventHandler(this.cmdCancelSettings_Click);
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSaveSettings.Depth = 0;
            this.cmdSaveSettings.Location = new System.Drawing.Point(207, 199);
            this.cmdSaveSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Primary = true;
            this.cmdSaveSettings.Size = new System.Drawing.Size(189, 40);
            this.cmdSaveSettings.TabIndex = 3;
            this.cmdSaveSettings.Text = "OK";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(12, 101);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(385, 33);
            this.txtUser.TabIndex = 4;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassw
            // 
            this.txtPassw.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassw.Location = new System.Drawing.Point(13, 157);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.Size = new System.Drawing.Size(384, 33);
            this.txtPassw.TabIndex = 5;
            this.txtPassw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassw.UseSystemPasswordChar = true;
            // 
            // lblInfoUsername
            // 
            this.lblInfoUsername.AutoSize = true;
            this.lblInfoUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoUsername.ForeColor = System.Drawing.Color.White;
            this.lblInfoUsername.Location = new System.Drawing.Point(12, 81);
            this.lblInfoUsername.Name = "lblInfoUsername";
            this.lblInfoUsername.Size = new System.Drawing.Size(38, 17);
            this.lblInfoUsername.TabIndex = 6;
            this.lblInfoUsername.Text = "User";
            // 
            // lblInfoPassword
            // 
            this.lblInfoPassword.AutoSize = true;
            this.lblInfoPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoPassword.ForeColor = System.Drawing.Color.White;
            this.lblInfoPassword.Location = new System.Drawing.Point(12, 137);
            this.lblInfoPassword.Name = "lblInfoPassword";
            this.lblInfoPassword.Size = new System.Drawing.Size(65, 17);
            this.lblInfoPassword.TabIndex = 7;
            this.lblInfoPassword.Text = "Passwort";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 247);
            this.Controls.Add(this.lblInfoPassword);
            this.Controls.Add(this.lblInfoUsername);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmdSaveSettings);
            this.Controls.Add(this.cmdCancelSettings);
            this.MaximumSize = new System.Drawing.Size(409, 247);
            this.Name = "frmSettings";
            this.Sizable = false;
            this.Text = "Anmeldedaten";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.VisibleChanged += new System.EventHandler(this.frmSettings_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton cmdCancelSettings;
        private MaterialSkin.Controls.MaterialRaisedButton cmdSaveSettings;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.Label lblInfoUsername;
        private System.Windows.Forms.Label lblInfoPassword;
    }
}