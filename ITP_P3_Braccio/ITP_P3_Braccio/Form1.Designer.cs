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
            this.lblPortState = new MaterialSkin.Controls.MaterialLabel();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cmdClosePort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdOpenPort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.cmdSave = new System.Windows.Forms.Button();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPortStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPageApp.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
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
            this.tabPageApp.Controls.Add(this.lblPortStatus);
            this.tabPageApp.Controls.Add(this.lblPortState);
            this.tabPageApp.Controls.Add(this.cboPorts);
            this.tabPageApp.Controls.Add(this.cmdClosePort);
            this.tabPageApp.Controls.Add(this.cmdOpenPort);
            this.tabPageApp.Location = new System.Drawing.Point(4, 29);
            this.tabPageApp.Name = "tabPageApp";
            this.tabPageApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApp.Size = new System.Drawing.Size(637, 488);
            this.tabPageApp.TabIndex = 0;
            this.tabPageApp.Text = "Anwendung";
            this.tabPageApp.UseVisualStyleBackColor = true;
            // 
            // lblPortState
            // 
            this.lblPortState.AutoSize = true;
            this.lblPortState.Depth = 0;
            this.lblPortState.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPortState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPortState.Location = new System.Drawing.Point(25, 41);
            this.lblPortState.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPortState.Name = "lblPortState";
            this.lblPortState.Size = new System.Drawing.Size(264, 27);
            this.lblPortState.TabIndex = 6;
            this.lblPortState.Text = "Wählen Sie einen Port aus";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(96, 108);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 28);
            this.cboPorts.TabIndex = 5;
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdClosePort.Depth = 0;
            this.cmdClosePort.Icon = null;
            this.cmdClosePort.Location = new System.Drawing.Point(356, 287);
            this.cmdClosePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Primary = true;
            this.cmdClosePort.Size = new System.Drawing.Size(242, 84);
            this.cmdClosePort.TabIndex = 4;
            this.cmdClosePort.Text = "Port schließen";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            // 
            // cmdOpenPort
            // 
            this.cmdOpenPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOpenPort.Depth = 0;
            this.cmdOpenPort.Icon = null;
            this.cmdOpenPort.Location = new System.Drawing.Point(356, 108);
            this.cmdOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Primary = true;
            this.cmdOpenPort.Size = new System.Drawing.Size(242, 84);
            this.cmdOpenPort.TabIndex = 2;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.cmdSave);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(637, 488);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Konfiguration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(35, 356);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(128, 54);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Speichern";
            this.cmdSave.UseVisualStyleBackColor = true;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.Depth = 0;
            this.lblPortStatus.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPortStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPortStatus.Location = new System.Drawing.Point(25, 410);
            this.lblPortStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(264, 27);
            this.lblPortStatus.TabIndex = 7;
            this.lblPortStatus.Text = "Wählen Sie einen Port aus";
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
            this.tabPageApp.ResumeLayout(false);
            this.tabPageApp.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageApp;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageHelp;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.IO.Ports.SerialPort serialPort1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdOpenPort;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdClosePort;
        private MaterialSkin.Controls.MaterialLabel lblPortState;
        private System.Windows.Forms.ComboBox cboPorts;
        private MaterialSkin.Controls.MaterialLabel lblPortStatus;
    }
}

