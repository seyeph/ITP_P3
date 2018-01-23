/**
 * author:      Fragner Julian
 * class:       4aHIT 1718
 * project:     P02 - RemoteControl
 * purpose:    Receives Text from an FTP-Server and passes it to an microcontroller
*/

using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace Blog_Creator
{
    public partial class frmMain : MaterialForm
    {
        #region Variables
        frmSettings settings = new frmSettings();

        // URL of FTP-Server including Textfield
        string serverURL;

        // ID of previous SEND
        string prevID;

        // When program started
        DateTime programStarted;
        #endregion

        #region Initialization
        public frmMain()
        {
            InitializeComponent();

            // for GUI
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Cyan700, MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.Blue600, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.WHITE);

            // fill GUI Elements
            string[] ports = SerialPort.GetPortNames();
            cboPorts.Items.AddRange(ports);

            // initialize prevID to default value
            prevID = "1999-12-31-59-59-59";       
        }
        #endregion

        #region GUI
        private void frmMain_Load(object sender, EventArgs e)
        {
            // for GUI
            materialDivider1Con.BackColor = Color.LightGray;
            // this.reportViewer1.RefreshReport();
        }

        private void sliderTime_Scroll(object sender, EventArgs e)
        {
            txtOutputSliderValue.Text = sliderTime.Value.ToString() + " ms";
        }

        // alter GUI when main procedure starts
        void startProgramGUI()
        {
            cmdStartProgram.Enabled = false;
            sliderTime.Enabled = false;
            cmdEndProgram.Enabled = true;
            txtWebserver.Enabled = false;
            lblWarningConn.Visible = false;
        }

        // alter GUI when main procedure ends
        void endProgramGUI()
        {
            cmdStartProgram.Enabled = true;
            sliderTime.Enabled = true;
            sliderTime.Value = 3000;
            txtOutputSliderValue.Text = "3000 ms";
            cmdEndProgram.Enabled = false;
            txtWebserver.Enabled = true;
            lblWarningConn.Visible = false;
            txtWebserver.Text = "ftp://my.webserver.at/test.txt";
            txtWebserver.ForeColor = Color.Gray;
            timer.Enabled = false;
        }

        // just for GUI
        private void txtWebserver_Enter(object sender, EventArgs e)
        {
            if (txtWebserver.Text == "ftp://my.webserver.at/test.txt")
            {
                txtWebserver.Text = "";
                txtWebserver.ForeColor = Color.Black;
            }
        }

        // just for GUI
        private void txtWebserver_Leave(object sender, EventArgs e)
        {
            if (txtWebserver.Text == "")
            {
                txtWebserver.Text = "ftp://my.webserver.at/test.txt";
                txtWebserver.ForeColor = Color.Gray;
            }
        }

        // Set URL to Textfield
        private void button1_Click(object sender, EventArgs e)
        {
            txtWebserver.Text = "ftp://fro.bplaced.net/text.txt";
            txtWebserver.ForeColor = Color.Black;
        }
        #endregion

        #region SerialHandler
        // Port öffnen
        private void cmdOpenPort_Click(object sender, EventArgs e)
        {
            if (cboPorts.SelectedIndex == -1)
            {
                rtxtStatus.AppendText("Es muss ein COM - Port ausgewählt sein.  - Keine Änderung.\n");
            }
            else
            {
                serialPort.PortName = cboPorts.SelectedItem.ToString();
                if (serialPort.IsOpen == false)
                {
                    bool ok = true;
                    if (rtxtProtocol.Text != "")
                    {
                        if (MessageBox.Show("Bei Öffnung eines neuen Ports wird das bestehende Protokoll verworfen.\nTrotzdem Fortfahren?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                        {
                            ok = false;
                        }
                    }
                    if (ok)
                    {
                        try
                        {
                            rtxtProtocol.Clear();
                            rtxtOutputReturnValues.Clear();

                            serialPort.Open();
                            rtxtStatus.AppendText("COM - Port " + serialPort.PortName + " wurde geöffnet.\n");
                            rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Port " + serialPort.PortName + " opened.\n");
                            cmdOpenPort.Enabled = false;
                            cmdClosePort.Enabled = true;
                            cboPorts.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Port konnte nicht geöffnet werden.\nOriginal Error: " + ex.Message);
                        }
                    }

                }
                else
                {
                    rtxtStatus.AppendText("COM - Port " + serialPort.PortName + " ist bereits offen. - Keine Änderung.\n");
                }
            }
        }

        // Close port
        private void cmdClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                rtxtStatus.AppendText("COM - Port " + serialPort.PortName + " wurde geschlossen.\n");
                rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Port " + serialPort.PortName + " closed.\n");
                cmdClosePort.Enabled = false;
                cmdOpenPort.Enabled = true;
                cboPorts.Enabled = true;
            }
            else
            {
                rtxtStatus.AppendText("Es ist derzeit kein COM - Port geöffnet. - Keine Änderung.\n");
            }
        }

        // send Message over SerialPort
        public bool sendMessageToController(int row, string mes)
        {
            bool rv = true;
            if (mes.Length < 1)
            {
                rv = false;
            }
            else
            {
                // MessageBox.Show(row.ToString() + mes);
                serialPort.WriteLine(row.ToString() + mes);
            }
            return rv;
        }
        #endregion

        #region FileHandler
        // save Protocol as Textfile
        private void cmdSaveProtocol_Click_1(object sender, EventArgs e)
        {
            string filePath;

            saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                try
                {
                    File.WriteAllLines(filePath, rtxtProtocol.Lines);
                    MessageBox.Show("Protokoll erfolgreich exportiert.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler bei Dateiöffnung.\nOriginal Message: " + ex.Message);
                }
            }
        }
        #endregion

        #region FTPHandler
        // test connection to FTP-Server
        bool testConnection(string user, string pass)
        {
            bool rv = true;
            try
            {
                FTPManager.getFileData(txtWebserver.Text, user, pass);
            }
            catch (Exception)
            {
                rv = false;
            }
            return rv;
        }
        #endregion

        #region MainProcedure
        // start receiving and sending data
        private void cmdStartProgram_Click(object sender, EventArgs e)
        {

            if (serialPort.IsOpen == false)
            {
                MessageBox.Show("Bitte zuerst einen Port öffnen!");
            }
            else
            {

                if (txtWebserver.Text == "" || txtWebserver.Text == "ftp://my.webserver.at/test.txt")
                {
                    MessageBox.Show("Wählen Sei eine URL zur Datei aus!");
                }
                else
                {
                    settings.ShowDialog();

                    if (testConnection(settings.User, settings.Password) == true)
                    {
                        serverURL = txtWebserver.Text;
                        startProgramGUI();
                        timer.Interval = sliderTime.Value;
                        timer.Enabled = true;

                        programStarted = DateTime.Now;
                        rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Program started (Update-Interval: " + sliderTime.Value.ToString() + "ms).\n");
                        rtxtOutputReturnValues.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Program started.\n");

                    }
                    else
                    {
                        MessageBox.Show("Fehler beim Verbindungsaufbau! Prüfen Sie den URL und Ihre Zugangsdaten!");
                        rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Starting program failed.\n");
                        rtxtOutputReturnValues.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Starting program failed.\n");
                    }
                }
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            try
            {
                byte[] arrFiledata = FTPManager.getFileData(serverURL, settings.User, settings.Password);

                string strFiledata = Decoder.ByteArrayToString(arrFiledata);

                lblWarningConn.Visible = false;

                // MessageBox.Show(strFiledata);

                string id;
                string mes1;
                string mes2;

                if (strFiledata != null && strFiledata.Length > 35)
                {
                    id = strFiledata.Substring(0, 19);
                    mes1 = strFiledata.Substring(20, 16);
                    mes2 = strFiledata.Substring(37);

                    mes1 = mes1.TrimEnd(' ');
                    mes2 = mes2.TrimEnd(' ');

                    // Remove Umlaute
                    mes1 = string.Join("", mes1.Split('Ä', 'ä', 'Ü', 'ü', 'Ö', 'ö', 'ß'));
                    mes2 = string.Join("", mes2.Split('Ä', 'ä', 'Ü', 'ü', 'Ö', 'ö', 'ß'));
                    
                    if (prevID != id)
                    {
                        prevID = id;

                        // send to µC
                        
                        sendMessageToController(1, mes1);
                        rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Message \"" + mes1 + "\" sent to µController (row 1)\n");
                        Thread.Sleep(1000);
                        sendMessageToController(2, mes2);
                        rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Message \"" + mes2 + "\" sent to µController (row 2)\n");

                        // test purposes:
                        // MessageBox.Show("\""+mes1+"\"" + " - " + "\""+mes2+"\"");
                    }
                }
            }
            catch (Exception)
            {
                lblWarningConn.Visible = true;
            }
        }

        private void cmdEndProgram_Click(object sender, EventArgs e)
        {
            endProgramGUI();
            rtxtProtocol.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Program ended (RunTime: " + DateTime.Now.Subtract(programStarted).ToString().Substring(0,8) + ").\n");
            rtxtOutputReturnValues.AppendText("[" + DateTime.Now.ToShortTimeString() + "] Program ended.\n");
        }
    }
        #endregion
}

// END OF FILE
