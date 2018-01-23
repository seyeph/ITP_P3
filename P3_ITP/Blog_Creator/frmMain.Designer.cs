namespace Blog_Creator
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.materialDivider1Con = new MaterialSkin.Controls.MaterialDivider();
            this.tabControlMain = new MaterialSkin.Controls.MaterialTabControl();
            this.tabConnection = new System.Windows.Forms.TabPage();
            this.flowActionButtonsCon = new System.Windows.Forms.FlowLayoutPanel();
            this.cmdOpenPort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdClosePort = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grpStatusCOM = new System.Windows.Forms.GroupBox();
            this.rtxtStatus = new System.Windows.Forms.RichTextBox();
            this.grpPort = new System.Windows.Forms.GroupBox();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.tabProcedure = new System.Windows.Forms.TabPage();
            this.lblWarningConn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtWebserver = new System.Windows.Forms.TextBox();
            this.cmdEndProgram = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmdStartProgram = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblInfoDelayValue = new System.Windows.Forms.Label();
            this.txtOutputSliderValue = new System.Windows.Forms.TextBox();
            this.grpProgramStatus = new System.Windows.Forms.GroupBox();
            this.rtxtOutputReturnValues = new System.Windows.Forms.RichTextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1Pro = new MaterialSkin.Controls.MaterialDivider();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo5000 = new System.Windows.Forms.Label();
            this.lblInfoDelay = new System.Windows.Forms.Label();
            this.sliderTime = new System.Windows.Forms.TrackBar();
            this.tabProtocol = new System.Windows.Forms.TabPage();
            this.cmdSaveProtocol = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpProtocol = new System.Windows.Forms.GroupBox();
            this.rtxtProtocol = new System.Windows.Forms.RichTextBox();
            this.tabSelectorMain = new MaterialSkin.Controls.MaterialTabSelector();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControlMain.SuspendLayout();
            this.tabConnection.SuspendLayout();
            this.flowActionButtonsCon.SuspendLayout();
            this.grpStatusCOM.SuspendLayout();
            this.grpPort.SuspendLayout();
            this.tabProcedure.SuspendLayout();
            this.grpProgramStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderTime)).BeginInit();
            this.tabProtocol.SuspendLayout();
            this.grpProtocol.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDivider1Con
            // 
            this.materialDivider1Con.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1Con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1Con.Depth = 0;
            this.materialDivider1Con.Location = new System.Drawing.Point(202, 16);
            this.materialDivider1Con.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1Con.Name = "materialDivider1Con";
            this.materialDivider1Con.Size = new System.Drawing.Size(692, 1);
            this.materialDivider1Con.TabIndex = 1;
            this.materialDivider1Con.Text = "materialDivider1Con";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabConnection);
            this.tabControlMain.Controls.Add(this.tabProcedure);
            this.tabControlMain.Controls.Add(this.tabProtocol);
            this.tabControlMain.Depth = 0;
            this.tabControlMain.Location = new System.Drawing.Point(12, 149);
            this.tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(908, 547);
            this.tabControlMain.TabIndex = 18;
            // 
            // tabConnection
            // 
            this.tabConnection.Controls.Add(this.flowActionButtonsCon);
            this.tabConnection.Controls.Add(this.grpStatusCOM);
            this.tabConnection.Controls.Add(this.grpPort);
            this.tabConnection.Controls.Add(this.materialDivider1Con);
            this.tabConnection.Location = new System.Drawing.Point(4, 25);
            this.tabConnection.Name = "tabConnection";
            this.tabConnection.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnection.Size = new System.Drawing.Size(900, 518);
            this.tabConnection.TabIndex = 0;
            this.tabConnection.Text = "Verbindung";
            this.tabConnection.UseVisualStyleBackColor = true;
            // 
            // flowActionButtonsCon
            // 
            this.flowActionButtonsCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowActionButtonsCon.Controls.Add(this.cmdOpenPort);
            this.flowActionButtonsCon.Controls.Add(this.cmdClosePort);
            this.flowActionButtonsCon.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowActionButtonsCon.Location = new System.Drawing.Point(202, 22);
            this.flowActionButtonsCon.Name = "flowActionButtonsCon";
            this.flowActionButtonsCon.Size = new System.Drawing.Size(692, 94);
            this.flowActionButtonsCon.TabIndex = 3;
            // 
            // cmdOpenPort
            // 
            this.cmdOpenPort.Depth = 0;
            this.cmdOpenPort.Location = new System.Drawing.Point(350, 3);
            this.cmdOpenPort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdOpenPort.Name = "cmdOpenPort";
            this.cmdOpenPort.Primary = true;
            this.cmdOpenPort.Size = new System.Drawing.Size(339, 94);
            this.cmdOpenPort.TabIndex = 4;
            this.cmdOpenPort.Text = "Port öffnen";
            this.cmdOpenPort.UseVisualStyleBackColor = true;
            this.cmdOpenPort.Click += new System.EventHandler(this.cmdOpenPort_Click);
            // 
            // cmdClosePort
            // 
            this.cmdClosePort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClosePort.Depth = 0;
            this.cmdClosePort.Location = new System.Drawing.Point(3, 3);
            this.cmdClosePort.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdClosePort.Name = "cmdClosePort";
            this.cmdClosePort.Primary = true;
            this.cmdClosePort.Size = new System.Drawing.Size(341, 94);
            this.cmdClosePort.TabIndex = 5;
            this.cmdClosePort.Text = "Port schließen";
            this.cmdClosePort.UseVisualStyleBackColor = true;
            this.cmdClosePort.Click += new System.EventHandler(this.cmdClosePort_Click);
            // 
            // grpStatusCOM
            // 
            this.grpStatusCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStatusCOM.Controls.Add(this.rtxtStatus);
            this.grpStatusCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatusCOM.ForeColor = System.Drawing.Color.White;
            this.grpStatusCOM.Location = new System.Drawing.Point(202, 122);
            this.grpStatusCOM.Name = "grpStatusCOM";
            this.grpStatusCOM.Padding = new System.Windows.Forms.Padding(15);
            this.grpStatusCOM.Size = new System.Drawing.Size(689, 393);
            this.grpStatusCOM.TabIndex = 7;
            this.grpStatusCOM.TabStop = false;
            this.grpStatusCOM.Text = "COM - Port Status";
            // 
            // rtxtStatus
            // 
            this.rtxtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtStatus.BackColor = System.Drawing.Color.Black;
            this.rtxtStatus.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStatus.ForeColor = System.Drawing.Color.White;
            this.rtxtStatus.HideSelection = false;
            this.rtxtStatus.Location = new System.Drawing.Point(18, 33);
            this.rtxtStatus.Name = "rtxtStatus";
            this.rtxtStatus.ReadOnly = true;
            this.rtxtStatus.Size = new System.Drawing.Size(653, 342);
            this.rtxtStatus.TabIndex = 0;
            this.rtxtStatus.Text = "";
            // 
            // grpPort
            // 
            this.grpPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPort.Controls.Add(this.cboPorts);
            this.grpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPort.ForeColor = System.Drawing.Color.White;
            this.grpPort.Location = new System.Drawing.Point(6, 6);
            this.grpPort.Name = "grpPort";
            this.grpPort.Size = new System.Drawing.Size(190, 509);
            this.grpPort.TabIndex = 3;
            this.grpPort.TabStop = false;
            this.grpPort.Text = "COM - Port";
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(19, 27);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(149, 30);
            this.cboPorts.TabIndex = 2;
            // 
            // tabProcedure
            // 
            this.tabProcedure.Controls.Add(this.lblWarningConn);
            this.tabProcedure.Controls.Add(this.button1);
            this.tabProcedure.Controls.Add(this.txtWebserver);
            this.tabProcedure.Controls.Add(this.cmdEndProgram);
            this.tabProcedure.Controls.Add(this.cmdStartProgram);
            this.tabProcedure.Controls.Add(this.lblInfoDelayValue);
            this.tabProcedure.Controls.Add(this.txtOutputSliderValue);
            this.tabProcedure.Controls.Add(this.grpProgramStatus);
            this.tabProcedure.Controls.Add(this.materialDivider1);
            this.tabProcedure.Controls.Add(this.materialDivider1Pro);
            this.tabProcedure.Controls.Add(this.lblInfo1);
            this.tabProcedure.Controls.Add(this.lblInfo5000);
            this.tabProcedure.Controls.Add(this.lblInfoDelay);
            this.tabProcedure.Controls.Add(this.sliderTime);
            this.tabProcedure.Location = new System.Drawing.Point(4, 25);
            this.tabProcedure.Name = "tabProcedure";
            this.tabProcedure.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedure.Size = new System.Drawing.Size(900, 518);
            this.tabProcedure.TabIndex = 1;
            this.tabProcedure.Text = "Programm";
            this.tabProcedure.UseVisualStyleBackColor = true;
            // 
            // lblWarningConn
            // 
            this.lblWarningConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarningConn.AutoSize = true;
            this.lblWarningConn.BackColor = System.Drawing.Color.Moccasin;
            this.lblWarningConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningConn.ForeColor = System.Drawing.Color.Red;
            this.lblWarningConn.Location = new System.Drawing.Point(688, 93);
            this.lblWarningConn.Name = "lblWarningConn";
            this.lblWarningConn.Size = new System.Drawing.Size(206, 29);
            this.lblWarningConn.TabIndex = 20;
            this.lblWarningConn.Text = "Keine Verbindung";
            this.lblWarningConn.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(815, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWebserver
            // 
            this.txtWebserver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWebserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebserver.ForeColor = System.Drawing.Color.Gray;
            this.txtWebserver.Location = new System.Drawing.Point(10, 6);
            this.txtWebserver.Name = "txtWebserver";
            this.txtWebserver.Size = new System.Drawing.Size(884, 34);
            this.txtWebserver.TabIndex = 28;
            this.txtWebserver.Text = "ftp://my.webserver.at/test.txt";
            this.txtWebserver.Enter += new System.EventHandler(this.txtWebserver_Enter);
            this.txtWebserver.Leave += new System.EventHandler(this.txtWebserver_Leave);
            // 
            // cmdEndProgram
            // 
            this.cmdEndProgram.Depth = 0;
            this.cmdEndProgram.Enabled = false;
            this.cmdEndProgram.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEndProgram.Location = new System.Drawing.Point(295, 46);
            this.cmdEndProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdEndProgram.Name = "cmdEndProgram";
            this.cmdEndProgram.Primary = true;
            this.cmdEndProgram.Size = new System.Drawing.Size(279, 110);
            this.cmdEndProgram.TabIndex = 27;
            this.cmdEndProgram.Text = "Programm beenden";
            this.cmdEndProgram.UseVisualStyleBackColor = true;
            this.cmdEndProgram.Click += new System.EventHandler(this.cmdEndProgram_Click);
            // 
            // cmdStartProgram
            // 
            this.cmdStartProgram.Depth = 0;
            this.cmdStartProgram.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStartProgram.Location = new System.Drawing.Point(10, 46);
            this.cmdStartProgram.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdStartProgram.Name = "cmdStartProgram";
            this.cmdStartProgram.Primary = true;
            this.cmdStartProgram.Size = new System.Drawing.Size(279, 110);
            this.cmdStartProgram.TabIndex = 26;
            this.cmdStartProgram.Text = "Programm starten";
            this.cmdStartProgram.UseVisualStyleBackColor = true;
            this.cmdStartProgram.Click += new System.EventHandler(this.cmdStartProgram_Click);
            // 
            // lblInfoDelayValue
            // 
            this.lblInfoDelayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoDelayValue.AutoSize = true;
            this.lblInfoDelayValue.ForeColor = System.Drawing.Color.White;
            this.lblInfoDelayValue.Location = new System.Drawing.Point(653, 137);
            this.lblInfoDelayValue.Name = "lblInfoDelayValue";
            this.lblInfoDelayValue.Size = new System.Drawing.Size(90, 17);
            this.lblInfoDelayValue.TabIndex = 25;
            this.lblInfoDelayValue.Text = "Verzögerung";
            // 
            // txtOutputSliderValue
            // 
            this.txtOutputSliderValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputSliderValue.Location = new System.Drawing.Point(749, 134);
            this.txtOutputSliderValue.Name = "txtOutputSliderValue";
            this.txtOutputSliderValue.ReadOnly = true;
            this.txtOutputSliderValue.Size = new System.Drawing.Size(145, 22);
            this.txtOutputSliderValue.TabIndex = 24;
            this.txtOutputSliderValue.Text = "3000 ms";
            this.txtOutputSliderValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpProgramStatus
            // 
            this.grpProgramStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProgramStatus.Controls.Add(this.rtxtOutputReturnValues);
            this.grpProgramStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProgramStatus.ForeColor = System.Drawing.Color.White;
            this.grpProgramStatus.Location = new System.Drawing.Point(10, 290);
            this.grpProgramStatus.Name = "grpProgramStatus";
            this.grpProgramStatus.Padding = new System.Windows.Forms.Padding(15);
            this.grpProgramStatus.Size = new System.Drawing.Size(884, 222);
            this.grpProgramStatus.TabIndex = 23;
            this.grpProgramStatus.TabStop = false;
            this.grpProgramStatus.Text = "Status";
            // 
            // rtxtOutputReturnValues
            // 
            this.rtxtOutputReturnValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOutputReturnValues.BackColor = System.Drawing.Color.Black;
            this.rtxtOutputReturnValues.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtOutputReturnValues.ForeColor = System.Drawing.Color.White;
            this.rtxtOutputReturnValues.HideSelection = false;
            this.rtxtOutputReturnValues.Location = new System.Drawing.Point(18, 33);
            this.rtxtOutputReturnValues.Name = "rtxtOutputReturnValues";
            this.rtxtOutputReturnValues.ReadOnly = true;
            this.rtxtOutputReturnValues.Size = new System.Drawing.Size(848, 171);
            this.rtxtOutputReturnValues.TabIndex = 0;
            this.rtxtOutputReturnValues.Text = "";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 282);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(888, 2);
            this.materialDivider1.TabIndex = 21;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider1Pro
            // 
            this.materialDivider1Pro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1Pro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1Pro.Depth = 0;
            this.materialDivider1Pro.Location = new System.Drawing.Point(6, 162);
            this.materialDivider1Pro.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1Pro.Name = "materialDivider1Pro";
            this.materialDivider1Pro.Size = new System.Drawing.Size(888, 2);
            this.materialDivider1Pro.TabIndex = 20;
            this.materialDivider1Pro.Text = "materialDivider1Pro";
            // 
            // lblInfo1
            // 
            this.lblInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.White;
            this.lblInfo1.Location = new System.Drawing.Point(3, 234);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(63, 23);
            this.lblInfo1.TabIndex = 19;
            this.lblInfo1.Text = "200ms";
            // 
            // lblInfo5000
            // 
            this.lblInfo5000.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo5000.AutoSize = true;
            this.lblInfo5000.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo5000.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo5000.ForeColor = System.Drawing.Color.White;
            this.lblInfo5000.Location = new System.Drawing.Point(821, 235);
            this.lblInfo5000.Name = "lblInfo5000";
            this.lblInfo5000.Size = new System.Drawing.Size(73, 23);
            this.lblInfo5000.TabIndex = 18;
            this.lblInfo5000.Text = "5000ms";
            // 
            // lblInfoDelay
            // 
            this.lblInfoDelay.AutoSize = true;
            this.lblInfoDelay.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoDelay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDelay.ForeColor = System.Drawing.Color.White;
            this.lblInfoDelay.Location = new System.Drawing.Point(6, 175);
            this.lblInfoDelay.Name = "lblInfoDelay";
            this.lblInfoDelay.Size = new System.Drawing.Size(274, 23);
            this.lblInfoDelay.TabIndex = 17;
            this.lblInfoDelay.Text = "Verzögerung Webserver - Updates";
            // 
            // sliderTime
            // 
            this.sliderTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.sliderTime.LargeChange = 500;
            this.sliderTime.Location = new System.Drawing.Point(6, 201);
            this.sliderTime.Maximum = 5000;
            this.sliderTime.Minimum = 200;
            this.sliderTime.Name = "sliderTime";
            this.sliderTime.Size = new System.Drawing.Size(888, 56);
            this.sliderTime.SmallChange = 100;
            this.sliderTime.TabIndex = 4;
            this.sliderTime.TickFrequency = 500;
            this.sliderTime.Value = 3000;
            this.sliderTime.Scroll += new System.EventHandler(this.sliderTime_Scroll);
            // 
            // tabProtocol
            // 
            this.tabProtocol.Controls.Add(this.cmdSaveProtocol);
            this.tabProtocol.Controls.Add(this.grpProtocol);
            this.tabProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProtocol.Location = new System.Drawing.Point(4, 25);
            this.tabProtocol.Name = "tabProtocol";
            this.tabProtocol.Padding = new System.Windows.Forms.Padding(3);
            this.tabProtocol.Size = new System.Drawing.Size(900, 518);
            this.tabProtocol.TabIndex = 2;
            this.tabProtocol.Text = "Verbindungsprotokoll";
            this.tabProtocol.UseVisualStyleBackColor = true;
            // 
            // cmdSaveProtocol
            // 
            this.cmdSaveProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSaveProtocol.AutoSize = true;
            this.cmdSaveProtocol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdSaveProtocol.Depth = 0;
            this.cmdSaveProtocol.Location = new System.Drawing.Point(591, 483);
            this.cmdSaveProtocol.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmdSaveProtocol.MouseState = MaterialSkin.MouseState.HOVER;
            this.cmdSaveProtocol.Name = "cmdSaveProtocol";
            this.cmdSaveProtocol.Primary = false;
            this.cmdSaveProtocol.Size = new System.Drawing.Size(313, 36);
            this.cmdSaveProtocol.TabIndex = 9;
            this.cmdSaveProtocol.Text = "Protokoll als Datei exportieren";
            this.cmdSaveProtocol.UseVisualStyleBackColor = true;
            this.cmdSaveProtocol.Click += new System.EventHandler(this.cmdSaveProtocol_Click_1);
            // 
            // grpProtocol
            // 
            this.grpProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProtocol.Controls.Add(this.rtxtProtocol);
            this.grpProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProtocol.ForeColor = System.Drawing.Color.White;
            this.grpProtocol.Location = new System.Drawing.Point(6, 6);
            this.grpProtocol.Name = "grpProtocol";
            this.grpProtocol.Padding = new System.Windows.Forms.Padding(15);
            this.grpProtocol.Size = new System.Drawing.Size(888, 458);
            this.grpProtocol.TabIndex = 8;
            this.grpProtocol.TabStop = false;
            this.grpProtocol.Text = "Kommunikation PC / µController";
            // 
            // rtxtProtocol
            // 
            this.rtxtProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtProtocol.BackColor = System.Drawing.Color.Black;
            this.rtxtProtocol.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtProtocol.ForeColor = System.Drawing.Color.Lime;
            this.rtxtProtocol.HideSelection = false;
            this.rtxtProtocol.Location = new System.Drawing.Point(18, 33);
            this.rtxtProtocol.Name = "rtxtProtocol";
            this.rtxtProtocol.ReadOnly = true;
            this.rtxtProtocol.Size = new System.Drawing.Size(852, 407);
            this.rtxtProtocol.TabIndex = 0;
            this.rtxtProtocol.Text = "";
            // 
            // tabSelectorMain
            // 
            this.tabSelectorMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabSelectorMain.BaseTabControl = this.tabControlMain;
            this.tabSelectorMain.Depth = 0;
            this.tabSelectorMain.Location = new System.Drawing.Point(-2, 77);
            this.tabSelectorMain.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorMain.Name = "tabSelectorMain";
            this.tabSelectorMain.Size = new System.Drawing.Size(936, 66);
            this.tabSelectorMain.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 708);
            this.Controls.Add(this.tabSelectorMain);
            this.Controls.Add(this.tabControlMain);
            this.MinimumSize = new System.Drawing.Size(932, 708);
            this.Name = "frmMain";
            this.Text = "Remote Control";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabConnection.ResumeLayout(false);
            this.flowActionButtonsCon.ResumeLayout(false);
            this.grpStatusCOM.ResumeLayout(false);
            this.grpPort.ResumeLayout(false);
            this.tabProcedure.ResumeLayout(false);
            this.tabProcedure.PerformLayout();
            this.grpProgramStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderTime)).EndInit();
            this.tabProtocol.ResumeLayout(false);
            this.tabProtocol.PerformLayout();
            this.grpProtocol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1Con;
        private MaterialSkin.Controls.MaterialTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabConnection;
        private System.Windows.Forms.TabPage tabProcedure;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMain;
        private System.Windows.Forms.TabPage tabProtocol;
        private System.Windows.Forms.GroupBox grpPort;
        private System.Windows.Forms.ComboBox cboPorts;
        private MaterialSkin.Controls.MaterialRaisedButton cmdClosePort;
        private MaterialSkin.Controls.MaterialRaisedButton cmdOpenPort;
        private System.Windows.Forms.GroupBox grpStatusCOM;
        private System.Windows.Forms.RichTextBox rtxtStatus;
        private System.Windows.Forms.Label lblInfoDelay;
        private MaterialSkin.Controls.MaterialDivider materialDivider1Pro;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.GroupBox grpProgramStatus;
        private System.Windows.Forms.RichTextBox rtxtOutputReturnValues;
        private System.Windows.Forms.Label lblInfoDelayValue;
        private System.Windows.Forms.GroupBox grpProtocol;
        private System.Windows.Forms.RichTextBox rtxtProtocol;
        private System.IO.Ports.SerialPort serialPort;
        private MaterialSkin.Controls.MaterialFlatButton cmdSaveProtocol;
        private System.Windows.Forms.FlowLayoutPanel flowActionButtonsCon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton cmdStartProgram;
        private System.Windows.Forms.Timer timer;
        private MaterialSkin.Controls.MaterialRaisedButton cmdEndProgram;
        private System.Windows.Forms.TextBox txtOutputSliderValue;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo5000;
        private System.Windows.Forms.TrackBar sliderTime;
        private System.Windows.Forms.TextBox txtWebserver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWarningConn;
    }
}

