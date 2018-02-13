namespace ITP_P3_Braccio
{
    partial class MainInterfacefrm
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
            this.tabPageApplication = new System.Windows.Forms.TabPage();
            this.cboSavedPositions = new System.Windows.Forms.ComboBox();
            this.cmdAddPause = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdAddMovement = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdSaveCSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdLoadCSV = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPause = new MaterialSkin.Controls.MaterialLabel();
            this.nudPause = new System.Windows.Forms.NumericUpDown();

            this.lboMovements = new System.Windows.Forms.ListBox();
            this.lboControlList = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.trackBarGripper = new System.Windows.Forms.TrackBar();
            this.trackBarWristVert = new System.Windows.Forms.TrackBar();
            this.trackBarWristRot = new System.Windows.Forms.TrackBar();
            this.trackBarEllbow = new System.Windows.Forms.TrackBar();
            this.trackBarShoulder = new System.Windows.Forms.TrackBar();
            this.trackBarBasic = new System.Windows.Forms.TrackBar();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.lblEnginePause = new MaterialSkin.Controls.MaterialLabel();
            this.numericEnginePause = new System.Windows.Forms.NumericUpDown();
            this.cmdSaveConfig = new MaterialSkin.Controls.MaterialRaisedButton();

            this.lblPort = new MaterialSkin.Controls.MaterialLabel();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cmdClosePort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdOpenPort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmdStart = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPageApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGripper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristVert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristRot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEllbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShoulder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBasic)).BeginInit();
            this.tabPageConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnginePause)).BeginInit();

            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPageApplication);
            this.materialTabControl1.Controls.Add(this.tabPageConfig);
            this.materialTabControl1.Controls.Add(this.tabPageHelp);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(12, 171);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1209, 1114);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPageApplication
            // 

            this.tabPageApplication.Controls.Add(this.cmdStart);
            this.tabPageApplication.Controls.Add(this.cboSavedPositions);
            this.tabPageApplication.Controls.Add(this.cmdAddPause);
            this.tabPageApplication.Controls.Add(this.cmdAddMovement);
            this.tabPageApplication.Controls.Add(this.cmdSaveCSV);
            this.tabPageApplication.Controls.Add(this.cmdLoadCSV);
            this.tabPageApplication.Controls.Add(this.cmdDelete);
            this.tabPageApplication.Controls.Add(this.materialLabel7);
            this.tabPageApplication.Controls.Add(this.materialLabel6);
            this.tabPageApplication.Controls.Add(this.materialLabel5);
            this.tabPageApplication.Controls.Add(this.materialLabel4);
            this.tabPageApplication.Controls.Add(this.materialLabel3);
            this.tabPageApplication.Controls.Add(this.lblPause);
            this.tabPageApplication.Controls.Add(this.nudPause);

            this.tabPageApplication.Controls.Add(this.lboMovements);

            this.tabPageApplication.Controls.Add(this.lboControlList);

            this.tabPageApplication.Controls.Add(this.materialLabel2);
            this.tabPageApplication.Controls.Add(this.materialLabel1);
            this.tabPageApplication.Controls.Add(this.trackBarGripper);
            this.tabPageApplication.Controls.Add(this.trackBarWristVert);
            this.tabPageApplication.Controls.Add(this.trackBarWristRot);
            this.tabPageApplication.Controls.Add(this.trackBarEllbow);
            this.tabPageApplication.Controls.Add(this.trackBarShoulder);
            this.tabPageApplication.Controls.Add(this.trackBarBasic);
            this.tabPageApplication.Location = new System.Drawing.Point(4, 29);
            this.tabPageApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageApplication.Name = "tabPageApplication";
            this.tabPageApplication.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageApplication.Size = new System.Drawing.Size(1201, 1081);
            this.tabPageApplication.TabIndex = 1;
            this.tabPageApplication.Text = "Anwendung";
            this.tabPageApplication.UseVisualStyleBackColor = true;
            // 
            // cboSavedPositions
            // 
            this.cboSavedPositions.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboSavedPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSavedPositions.FormattingEnabled = true;
            this.cboSavedPositions.Location = new System.Drawing.Point(226, 67);
            this.cboSavedPositions.Name = "cboSavedPositions";
            this.cboSavedPositions.Size = new System.Drawing.Size(302, 24);
            this.cboSavedPositions.TabIndex = 23;
            this.cboSavedPositions.SelectedIndexChanged += new System.EventHandler(this.cboSavedPositions_SelectedIndexChanged);
            // 
            // cmdAddPause
            // 
            this.cmdAddPause.AutoSize = true;
            this.cmdAddPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddPause.Depth = 0;
            this.cmdAddPause.Icon = null;

            this.cmdAddPause.Location = new System.Drawing.Point(23, 947);

            this.cmdAddPause.Location = new System.Drawing.Point(808, 552);

            this.cmdAddPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAddPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdAddPause.Name = "cmdAddPause";
            this.cmdAddPause.Primary = true;
            this.cmdAddPause.Size = new System.Drawing.Size(219, 36);
            this.cmdAddPause.TabIndex = 22;
            this.cmdAddPause.Text = "Pause hinzufügen";
            this.cmdAddPause.UseVisualStyleBackColor = true;
            // 
            // cmdAddMovement
            // 
            this.cmdAddMovement.AutoSize = true;
            this.cmdAddMovement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAddMovement.Depth = 0;
            this.cmdAddMovement.Icon = null;

            this.cmdAddMovement.Location = new System.Drawing.Point(644, 711);

            this.cmdAddMovement.Location = new System.Drawing.Point(226, 662);

            this.cmdAddMovement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdAddMovement.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdAddMovement.Name = "cmdAddMovement";
            this.cmdAddMovement.Primary = true;
            this.cmdAddMovement.Size = new System.Drawing.Size(265, 36);
            this.cmdAddMovement.TabIndex = 21;
            this.cmdAddMovement.Text = "Bewegung hinzufügen";
            this.cmdAddMovement.UseVisualStyleBackColor = true;
            // 
            // cmdSaveCSV
            // 
            this.cmdSaveCSV.AutoSize = true;
            this.cmdSaveCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSaveCSV.Depth = 0;
            this.cmdSaveCSV.Icon = null;
            this.cmdSaveCSV.Location = new System.Drawing.Point(828, 960);
            this.cmdSaveCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSaveCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSaveCSV.Name = "cmdSaveCSV";
            this.cmdSaveCSV.Primary = true;

            this.cmdSaveCSV.Size = new System.Drawing.Size(178, 36);

            this.cmdSaveCSV.Size = new System.Drawing.Size(182, 36);

            this.cmdSaveCSV.TabIndex = 20;
            this.cmdSaveCSV.Text = "Ablauf speichern";
            this.cmdSaveCSV.UseVisualStyleBackColor = true;
            // 
            // cmdLoadCSV
            // 
            this.cmdLoadCSV.AutoSize = true;
            this.cmdLoadCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdLoadCSV.Depth = 0;
            this.cmdLoadCSV.Icon = null;
            this.cmdLoadCSV.Location = new System.Drawing.Point(644, 960);
            this.cmdLoadCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLoadCSV.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdLoadCSV.Name = "cmdLoadCSV";
            this.cmdLoadCSV.Primary = true;

            this.cmdLoadCSV.Size = new System.Drawing.Size(145, 36);
            this.cmdLoadCSV.Size = new System.Drawing.Size(144, 36);

            this.cmdLoadCSV.TabIndex = 19;
            this.cmdLoadCSV.Text = "Ablauf laden";
            this.cmdLoadCSV.UseVisualStyleBackColor = true;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdDelete.Depth = 0;
            this.cmdDelete.Icon = null;
            this.cmdDelete.Location = new System.Drawing.Point(644, 773);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Primary = true;
            this.cmdDelete.Size = new System.Drawing.Size(231, 36);
            this.cmdDelete.TabIndex = 18;
            this.cmdDelete.Text = "Bewegung löschen";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(22, 749);
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

            this.materialLabel6.Size = new System.Drawing.Size(185, 24);

            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Handgelenk Drehung";
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

            this.materialLabel5.Size = new System.Drawing.Size(177, 24);

            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Handgelenk vertikal";
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
            this.lblPause.Location = new System.Drawing.Point(19, 869);
            this.lblPause.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(130, 27);
            this.lblPause.TabIndex = 11;
            this.lblPause.Text = "Pause in ms";
            // 
            // nudPause
            // 
            this.nudPause.Location = new System.Drawing.Point(162, 869);
            this.nudPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPause.Name = "nudPause";
            this.nudPause.Size = new System.Drawing.Size(120, 26);
            this.nudPause.TabIndex = 10;
            // 

            // lboMovements
            // 
            this.lboMovements.FormattingEnabled = true;
            this.lboMovements.ItemHeight = 20;
            this.lboMovements.Location = new System.Drawing.Point(644, 129);
            this.lboMovements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboMovements.Name = "lboMovements";
            this.lboMovements.Size = new System.Drawing.Size(396, 524);
            this.lboMovements.TabIndex = 9;

            // lboControlList
            // 
            this.lboControlList.FormattingEnabled = true;
            this.lboControlList.ItemHeight = 16;
            this.lboControlList.Location = new System.Drawing.Point(572, 119);
            this.lboControlList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboControlList.Name = "lboControlList";
            this.lboControlList.Size = new System.Drawing.Size(396, 404);
            this.lboControlList.TabIndex = 9;

            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 52);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";

            this.materialLabel2.Size = new System.Drawing.Size(632, 37);

            this.materialLabel2.Size = new System.Drawing.Size(581, 24);

            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Geben Sie die Position der Teile in Grad an oder wählen sie eine aus";
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
            this.trackBarGripper.Location = new System.Drawing.Point(254, 749);
            this.trackBarGripper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarGripper.Maximum = 73;
            this.trackBarGripper.Minimum = 10;
            this.trackBarGripper.Name = "trackBarGripper";
            this.trackBarGripper.Size = new System.Drawing.Size(340, 69);
            this.trackBarGripper.TabIndex = 6;
            this.trackBarGripper.Value = 10;
            // 
            // trackBarWristVert
            // 
            this.trackBarWristVert.Location = new System.Drawing.Point(254, 626);
            this.trackBarWristVert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarWristVert.Maximum = 180;
            this.trackBarWristVert.Name = "trackBarWristVert";
            this.trackBarWristVert.Size = new System.Drawing.Size(340, 69);
            this.trackBarWristVert.TabIndex = 5;
            this.trackBarWristVert.Value = 90;
            // 
            // trackBarWristRot
            // 

            this.trackBarWristHor.Location = new System.Drawing.Point(254, 514);
            this.trackBarWristHor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarWristHor.Name = "trackBarWristHor";
            this.trackBarWristHor.Size = new System.Drawing.Size(340, 69);
            this.trackBarWristHor.TabIndex = 4;

            this.trackBarWristRot.Location = new System.Drawing.Point(226, 397);
            this.trackBarWristRot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarWristRot.Maximum = 180;
            this.trackBarWristRot.Name = "trackBarWristRot";
            this.trackBarWristRot.Size = new System.Drawing.Size(302, 56);
            this.trackBarWristRot.TabIndex = 4;

            // 
            // trackBarEllbow
            // 

            this.trackBarElbow.Location = new System.Drawing.Point(254, 398);
            this.trackBarElbow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarElbow.Name = "trackBarElbow";
            this.trackBarElbow.Size = new System.Drawing.Size(340, 69);
            this.trackBarElbow.TabIndex = 3;

            this.trackBarEllbow.Location = new System.Drawing.Point(226, 318);
            this.trackBarEllbow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarEllbow.Maximum = 180;
            this.trackBarEllbow.Name = "trackBarEllbow";
            this.trackBarEllbow.Size = new System.Drawing.Size(302, 56);
            this.trackBarEllbow.TabIndex = 3;
            // 
            // trackBarShoulder
            // 
            this.trackBarShoulder.Location = new System.Drawing.Point(254, 285);
            this.trackBarShoulder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarShoulder.Maximum = 165;
            this.trackBarShoulder.Minimum = 15;
            this.trackBarShoulder.Name = "trackBarShoulder";
            this.trackBarShoulder.Size = new System.Drawing.Size(340, 69);
            this.trackBarShoulder.TabIndex = 2;
            this.trackBarShoulder.Value = 15;
            // 
            // trackBarBasic
            // 
            this.trackBarBasic.Location = new System.Drawing.Point(254, 170);
            this.trackBarBasic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBarBasic.Maximum = 180;
            this.trackBarBasic.Name = "trackBarBasic";
            this.trackBarBasic.Size = new System.Drawing.Size(340, 69);
            this.trackBarBasic.TabIndex = 1;
            // 
            // tabPageConfig
            // 

            this.tabPageConfig.Controls.Add(this.lblEnginePause);
            this.tabPageConfig.Controls.Add(this.numericEnginePause);
            this.tabPageConfig.Controls.Add(this.cmdSaveConfig);

            this.tabPageConfig.Controls.Add(this.lblPort);
            this.tabPageConfig.Controls.Add(this.cboPorts);
            this.tabPageConfig.Controls.Add(this.cmdClosePort);
            this.tabPageConfig.Controls.Add(this.cmdOpenPort);

            this.tabPageConfig.Location = new System.Drawing.Point(4, 29);
            this.tabPageConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Size = new System.Drawing.Size(1201, 1081);

            this.tabPageConfig.Location = new System.Drawing.Point(4, 25);
            this.tabPageConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageConfig.Size = new System.Drawing.Size(1044, 725);

            this.tabPageConfig.TabIndex = 0;
            this.tabPageConfig.Text = "Konfiguration";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            //
            // lblEnginePause
            // 
            this.lblEnginePause.AutoSize = true;
            this.lblEnginePause.Depth = 0;
            this.lblEnginePause.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEnginePause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEnginePause.Location = new System.Drawing.Point(443, 33);
            this.lblEnginePause.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEnginePause.Name = "lblEnginePause";
            this.lblEnginePause.Size = new System.Drawing.Size(112, 24);
            this.lblEnginePause.TabIndex = 12;
            this.lblEnginePause.Text = "Motorpause";
            // 
            // numericEnginePause
            // 
            this.numericEnginePause.Location = new System.Drawing.Point(447, 72);
            this.numericEnginePause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericEnginePause.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericEnginePause.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEnginePause.Name = "numericEnginePause";
            this.numericEnginePause.Size = new System.Drawing.Size(107, 22);
            this.numericEnginePause.TabIndex = 11;
            this.numericEnginePause.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericEnginePause.ValueChanged += new System.EventHandler(this.numericEnginePause_ValueChanged);
            // 
            // cmdSaveConfig
            // 
            this.cmdSaveConfig.AutoSize = true;
            this.cmdSaveConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSaveConfig.Depth = 0;
            this.cmdSaveConfig.Icon = null;
            this.cmdSaveConfig.Location = new System.Drawing.Point(26, 194);
            this.cmdSaveConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSaveConfig.Name = "cmdSaveConfig";
            this.cmdSaveConfig.Primary = true;
            this.cmdSaveConfig.Size = new System.Drawing.Size(252, 36);
            this.cmdSaveConfig.TabIndex = 7;
            this.cmdSaveConfig.Text = "Konfiguration speichern";
            this.cmdSaveConfig.UseVisualStyleBackColor = true;
            this.cmdSaveConfig.Click += new System.EventHandler(this.cmdSaveConfig_Click);
            // 

            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Depth = 0;

            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(25, 41);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(492, 46);

            this.lblPort.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPort.Location = new System.Drawing.Point(22, 33);
            this.lblPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(228, 24);

            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Wählen Sie einen Port aus";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;

            this.cboPorts.Location = new System.Drawing.Point(30, 97);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(471, 28);

            this.cboPorts.Location = new System.Drawing.Point(26, 59);
            this.cboPorts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(108, 24);

            this.cboPorts.TabIndex = 5;
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.AutoSize = true;
            this.cmdClosePort.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdClosePort.Depth = 0;
            this.cmdClosePort.Icon = null;

            this.cmdClosePort.Location = new System.Drawing.Point(239, 415);

            this.cmdClosePort.Location = new System.Drawing.Point(167, 87);

            this.cmdClosePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdClosePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Primary = true;

            this.cmdClosePort.Size = new System.Drawing.Size(189, 36);

            this.cmdClosePort.Size = new System.Drawing.Size(160, 36);

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

            this.cmdOpenPort.Location = new System.Drawing.Point(30, 415);

            this.cmdOpenPort.Location = new System.Drawing.Point(26, 87);

            this.cmdOpenPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Primary = true;
            this.cmdOpenPort.Size = new System.Drawing.Size(159, 36);

            this.cmdOpenPort.Size = new System.Drawing.Size(135, 36);

            this.cmdOpenPort.TabIndex = 2;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Location = new System.Drawing.Point(4, 29);
            this.tabPageHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Size = new System.Drawing.Size(1432, 1081);
            this.tabPageHelp.TabIndex = 2;
            this.tabPageHelp.Text = "Hilfe";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(12, 105);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1205, 60);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStart.Location = new System.Drawing.Point(1066, 129);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 524);
            this.cmdStart.TabIndex = 23;
            this.cmdStart.Text = "S\r\nT\r\nA\r\nR\r\nT";
            this.cmdStart.UseVisualStyleBackColor = true;
            // 
            // MainInterfacefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 1296);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainInterfacefrm";
            this.Text = "Braccio";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPageApplication.ResumeLayout(false);
            this.tabPageApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGripper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristVert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWristRot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEllbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShoulder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBasic)).EndInit();
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)(this.numericEnginePause)).EndInit();

            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageApplication;
        private System.Windows.Forms.TabPage tabPageHelp;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.IO.Ports.SerialPort serialPort1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdOpenPort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdClosePort;
        private MaterialSkin.Controls.MaterialLabel lblPort;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.TrackBar trackBarGripper;
        private System.Windows.Forms.TrackBar trackBarWristVert;
        private System.Windows.Forms.TrackBar trackBarWristRot;
        private System.Windows.Forms.TrackBar trackBarEllbow;
        private System.Windows.Forms.TrackBar trackBarShoulder;
        private System.Windows.Forms.TrackBar trackBarBasic;

        private System.Windows.Forms.ListBox lboMovements;

        private System.Windows.Forms.ListBox lboControlList;

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
        private MaterialSkin.Controls.MaterialRaisedButton cmdAddMovement;
        private MaterialSkin.Controls.MaterialRaisedButton cmdAddPause;

        private System.Windows.Forms.Button cmdStart;

        private System.Windows.Forms.ComboBox cboSavedPositions;
        private MaterialSkin.Controls.MaterialRaisedButton cmdSaveConfig;
        private MaterialSkin.Controls.MaterialLabel lblEnginePause;
        private System.Windows.Forms.NumericUpDown numericEnginePause;

    }
}

