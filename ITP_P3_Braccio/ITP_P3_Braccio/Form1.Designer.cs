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
            this.lblPortStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lblPort = new MaterialSkin.Controls.MaterialLabel();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cmdClosePort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdOpenPort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPause = new MaterialSkin.Controls.MaterialLabel();
            this.nudPause = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.trackBarGripper = new System.Windows.Forms.TrackBar();
            this.trackBarWristVert = new System.Windows.Forms.TrackBar();
            this.trackBarWristHor = new System.Windows.Forms.TrackBar();
            this.trackBarElbow = new System.Windows.Forms.TrackBar();
            this.trackBarShoulder = new System.Windows.Forms.TrackBar();
            this.trackBarBasic = new System.Windows.Forms.TrackBar();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdLoadCSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdSaveCSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabControl1.SuspendLayout();
            this.tabPageApp.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGripper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShoulder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBasic)).BeginInit();
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
            this.materialTabControl1.Size = new System.Drawing.Size(1184, 942);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageApp
            // 
            this.tabPageApp.Controls.Add(this.lblPortStatus);
            this.tabPageApp.Controls.Add(this.lblPort);
            this.tabPageApp.Controls.Add(this.cboPorts);
            this.tabPageApp.Controls.Add(this.cmdClosePort);
            this.tabPageApp.Controls.Add(this.cmdOpenPort);
            this.tabPageApp.Location = new System.Drawing.Point(4, 29);
            this.tabPageApp.Name = "tabPageApp";
            this.tabPageApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApp.Size = new System.Drawing.Size(1066, 825);
            this.tabPageApp.TabIndex = 0;
            this.tabPageApp.Text = "Anwendung";
            this.tabPageApp.UseVisualStyleBackColor = true;
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
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Depth = 0;
            this.lblPort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(25, 41);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(264, 27);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Wählen Sie einen Port aus";
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
            this.cmdClosePort.AutoSize = true;
            this.cmdClosePort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdClosePort.Depth = 0;
            this.cmdClosePort.Icon = null;
            this.cmdClosePort.Location = new System.Drawing.Point(356, 287);
            this.cmdClosePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Primary = true;
            this.cmdClosePort.Size = new System.Drawing.Size(189, 36);
            this.cmdClosePort.TabIndex = 4;
            this.cmdClosePort.Text = "Port schließen";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            // 
            // cmdOpenPort
            // 
            this.cmdOpenPort.AutoSize = true;
            this.cmdOpenPort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdOpenPort.Depth = 0;
            this.cmdOpenPort.Icon = null;
            this.cmdOpenPort.Location = new System.Drawing.Point(356, 108);
            this.cmdOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Primary = true;
            this.cmdOpenPort.Size = new System.Drawing.Size(159, 36);
            this.cmdOpenPort.TabIndex = 2;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.cmdSaveCSV);
            this.tabPageConfig.Controls.Add(this.cmdLoadCSV);
            this.tabPageConfig.Controls.Add(this.cmdDelete);
            this.tabPageConfig.Controls.Add(this.cmdStart);
            this.tabPageConfig.Controls.Add(this.materialLabel7);
            this.tabPageConfig.Controls.Add(this.materialLabel6);
            this.tabPageConfig.Controls.Add(this.materialLabel5);
            this.tabPageConfig.Controls.Add(this.materialLabel4);
            this.tabPageConfig.Controls.Add(this.materialLabel3);
            this.tabPageConfig.Controls.Add(this.lblPause);
            this.tabPageConfig.Controls.Add(this.nudPause);
            this.tabPageConfig.Controls.Add(this.listBox1);
            this.tabPageConfig.Controls.Add(this.materialLabel2);
            this.tabPageConfig.Controls.Add(this.materialLabel1);
            this.tabPageConfig.Controls.Add(this.trackBarGripper);
            this.tabPageConfig.Controls.Add(this.trackBarWristVert);
            this.tabPageConfig.Controls.Add(this.trackBarWristHor);
            this.tabPageConfig.Controls.Add(this.trackBarElbow);
            this.tabPageConfig.Controls.Add(this.trackBarShoulder);
            this.tabPageConfig.Controls.Add(this.trackBarBasic);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(1176, 909);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Konfiguration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(23, 749);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(78, 27);
            this.materialLabel7.TabIndex = 16;
            this.materialLabel7.Text = "Greifer";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(18, 626);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(203, 27);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Handgelenk vertikal";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(18, 514);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(230, 27);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Handgelenk horizontal";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(18, 398);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(120, 27);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Ellenbogen";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 285);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 27);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Schulter";
            // 
            // lblPause
            // 
            this.lblPause.AutoSize = true;
            this.lblPause.Depth = 0;
            this.lblPause.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPause.Location = new System.Drawing.Point(639, 700);
            this.lblPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(73, 27);
            this.lblPause.TabIndex = 11;
            this.lblPause.Text = "Pause";
            // 
            // nudPause
            // 
            this.nudPause.Location = new System.Drawing.Point(782, 700);
            this.nudPause.Name = "nudPause";
            this.nudPause.Size = new System.Drawing.Size(120, 26);
            this.nudPause.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(644, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(395, 524);
            this.listBox1.TabIndex = 9;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(36, 49);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(419, 27);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Geben Sie die Position der Teile in Grad an";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(18, 170);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 27);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Basic ";
            // 
            // trackBarGripper
            // 
            this.trackBarGripper.Location = new System.Drawing.Point(254, 740);
            this.trackBarGripper.Name = "trackBarGripper";
            this.trackBarGripper.Size = new System.Drawing.Size(340, 69);
            this.trackBarGripper.TabIndex = 6;
            // 
            // trackBarWristVert
            // 
            this.trackBarWristVert.Location = new System.Drawing.Point(254, 601);
            this.trackBarWristVert.Name = "trackBarWristVert";
            this.trackBarWristVert.Size = new System.Drawing.Size(340, 69);
            this.trackBarWristVert.TabIndex = 5;
            // 
            // trackBarWristHor
            // 
            this.trackBarWristHor.Location = new System.Drawing.Point(254, 496);
            this.trackBarWristHor.Name = "trackBarWristHor";
            this.trackBarWristHor.Size = new System.Drawing.Size(340, 69);
            this.trackBarWristHor.TabIndex = 4;
            // 
            // trackBarElbow
            // 
            this.trackBarElbow.Location = new System.Drawing.Point(254, 398);
            this.trackBarElbow.Name = "trackBarElbow";
            this.trackBarElbow.Size = new System.Drawing.Size(340, 69);
            this.trackBarElbow.TabIndex = 3;
            // 
            // trackBarShoulder
            // 
            this.trackBarShoulder.Location = new System.Drawing.Point(254, 264);
            this.trackBarShoulder.Name = "trackBarShoulder";
            this.trackBarShoulder.Size = new System.Drawing.Size(340, 69);
            this.trackBarShoulder.TabIndex = 2;
            // 
            // trackBarBasic
            // 
            this.trackBarBasic.Location = new System.Drawing.Point(254, 146);
            this.trackBarBasic.Name = "trackBarBasic";
            this.trackBarBasic.Size = new System.Drawing.Size(340, 69);
            this.trackBarBasic.TabIndex = 1;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Location = new System.Drawing.Point(4, 29);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(1066, 825);
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1070, 60);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdStart
            // 
            this.cmdStart.AutoSize = true;
            this.cmdStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdStart.Depth = 0;
            this.cmdStart.Icon = null;
            this.cmdStart.Location = new System.Drawing.Point(644, 773);
            this.cmdStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Primary = true;
            this.cmdStart.Size = new System.Drawing.Size(87, 36);
            this.cmdStart.TabIndex = 17;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdDelete.Depth = 0;
            this.cmdDelete.Icon = null;
            this.cmdDelete.Location = new System.Drawing.Point(644, 828);
            this.cmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Primary = true;
            this.cmdDelete.Size = new System.Drawing.Size(231, 36);
            this.cmdDelete.TabIndex = 18;
            this.cmdDelete.Text = "Bewegung löschen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // cmdLoadCSV
            // 
            this.cmdLoadCSV.AutoSize = true;
            this.cmdLoadCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdLoadCSV.Depth = 0;
            this.cmdLoadCSV.Icon = null;
            this.cmdLoadCSV.Location = new System.Drawing.Point(900, 773);
            this.cmdLoadCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdLoadCSV.Name = "cmdLoadCSV";
            this.cmdLoadCSV.Primary = true;
            this.cmdLoadCSV.Size = new System.Drawing.Size(145, 36);
            this.cmdLoadCSV.TabIndex = 19;
            this.cmdLoadCSV.Text = "CSV öffnen";
            this.cmdLoadCSV.UseVisualStyleBackColor = true;
            // 
            // cmdSaveCSV
            // 
            this.cmdSaveCSV.AutoSize = true;
            this.cmdSaveCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSaveCSV.Depth = 0;
            this.cmdSaveCSV.Icon = null;
            this.cmdSaveCSV.Location = new System.Drawing.Point(900, 827);
            this.cmdSaveCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSaveCSV.Name = "cmdSaveCSV";
            this.cmdSaveCSV.Primary = true;
            this.cmdSaveCSV.Size = new System.Drawing.Size(178, 36);
            this.cmdSaveCSV.TabIndex = 20;
            this.cmdSaveCSV.Text = "CSV Speichern";
            this.cmdSaveCSV.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 1125);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Form1";
            this.Text = "Braccio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageApp.ResumeLayout(false);
            this.tabPageApp.PerformLayout();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGripper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarElbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShoulder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBasic)).EndInit();
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdClosePort;
        private MaterialSkin.Controls.MaterialLabel lblPort;
        private System.Windows.Forms.ComboBox cboPorts;
        private MaterialSkin.Controls.MaterialLabel lblPortStatus;
        private System.Windows.Forms.TrackBar trackBarGripper;
        private System.Windows.Forms.TrackBar trackBarWristVert;
        private System.Windows.Forms.TrackBar trackBarWristHor;
        private System.Windows.Forms.TrackBar trackBarElbow;
        private System.Windows.Forms.TrackBar trackBarShoulder;
        private System.Windows.Forms.TrackBar trackBarBasic;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblPause;
        private System.Windows.Forms.NumericUpDown nudPause;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton cmdSaveCSV;
        private MaterialSkin.Controls.MaterialRaisedButton cmdLoadCSV;
        private MaterialSkin.Controls.MaterialRaisedButton cmdDelete;
        private MaterialSkin.Controls.MaterialRaisedButton cmdStart;
    }
}

