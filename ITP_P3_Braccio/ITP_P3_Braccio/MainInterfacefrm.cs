using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;
using System.IO.Ports;

namespace ITP_P3_Braccio
{
    public partial class MainInterfacefrm : MaterialForm
    {
        #region variables
        private Configuration config;   // configuration
        private ControlList controlList;
        private string configPath = "./ProgramData/config.csv";
        #endregion

        public MainInterfacefrm()
        {
            #region initialize
            InitializeComponent();
            // read config from file
            try
            {
                config = FileOperator.ReadConfig(configPath);
            }
            catch (Exception)
            {
                MessageBox.Show("Konfiguration konnte nicht gelesen werden.\nStandardkonfiguration wurde erstellt");
                config = new Configuration() { EnginePause = 20 };

                // add standard positions
            }
            controlList = new ControlList();

            #region initializeControls
            cboPorts.Items.AddRange(SerialPort.GetPortNames());
            numericEnginePause.Value = config.EnginePause;
            cboSavedPositions.Items.Add("slider input");
            cboSavedPositions.SelectedIndex = 0;
            foreach (SavedPosition p in config.StandardPositions)
            {
                cboSavedPositions.Items.Add(p.Name);
            }
            #endregion
            #endregion

            #region appearance
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange400, Primary.Orange800,
                Primary.Orange500, Accent.DeepOrange700,
                TextShade.WHITE);
            #endregion
        }

        #region events
        private void cmdSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                FileOperator.WriteConfig(configPath, config);
            }
            catch (Exception)
            {
                MessageBox.Show("Konfiguration konnte nicht gespeichert werden");
            }
        }

        private void cboSavedPositions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSavedPositions.SelectedIndex != 0)
            {
                //  get position from config
                SavedPosition position = config.GetMove(cboSavedPositions.SelectedItem.ToString());
                trackBarBasic.Value = position.BasicAngle;
                trackBarShoulder.Value = position.SoulderAngle;
                trackBarEllbow.Value = position.EllbowAngle;
                trackBarWristVert.Value = position.HandAngle_ver;
                trackBarWristRot.Value = position.HandAngle_rot;
                trackBarGripper.Value = position.Gripper;
            }
        }

        private void numericEnginePause_ValueChanged(object sender, EventArgs e)
        {
            config.EnginePause = (int)numericEnginePause.Value;
        }

        #endregion

        private void cmdAddMovement_Click(object sender, EventArgs e)
        {
            Position position = new Position(trackBarBasic.Value, trackBarShoulder.Value, trackBarEllbow.Value, trackBarWristRot.Value, trackBarWristVert.Value, trackBarGripper.Value);
            controlList.Add(position);
            lboControlList.Items.Add(position.ToString());
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lboControlList.SelectedIndex == -1) { throw new IndexOutOfRangeException(); }
                else
                {
                    controlList.Remove(lboControlList.SelectedIndex);
                    lboControlList.Items.Remove(lboControlList.SelectedItem);
                    lboControlList.Show();
                }

            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Kein Element zum Entfernen ausgewählt!");
            }

        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Communication.Move(serialPort1, config.EnginePause, controlList);
            }
            else
            {
                MessageBox.Show("Port ist noch nicht geöffnet!");
            }
        }

        private void cmdAddPause_Click(object sender, EventArgs e)
        {
            Pause pause = new Pause(Convert.ToInt32(nudPause.Value));
            controlList.Add(pause);
            lboControlList.Items.Add(pause.ToString());
        }
    }
}
