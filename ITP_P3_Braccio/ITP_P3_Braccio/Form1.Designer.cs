namespace ITP_P3_Braccio
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageApp = new System.Windows.Forms.TabPage();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageApp);
            this.materialTabControl1.Controls.Add(this.tabPageConfig);
            this.materialTabControl1.Controls.Add(this.tabPageHelp);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 171);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(645, 521);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageApp
            // 
            this.tabPageApp.Location = new System.Drawing.Point(4, 29);
            this.tabPageApp.Name = "tabPageApp";
            this.tabPageApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApp.Size = new System.Drawing.Size(637, 488);
            this.tabPageApp.TabIndex = 0;
            this.tabPageApp.Text = "Anwendung";
            this.tabPageApp.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(637, 488);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Konfiguration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Location = new System.Drawing.Point(4, 29);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(637, 488);
            this.tabPageHelp.TabIndex = 2;
            this.tabPageHelp.Text = "Hilfe";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 105);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(641, 60);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 704);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Braccio";
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageApp;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageHelp;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

