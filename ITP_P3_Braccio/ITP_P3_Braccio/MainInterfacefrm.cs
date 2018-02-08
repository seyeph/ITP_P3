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

namespace ITP_P3_Braccio
{
    public partial class MainInterfacefrm : MaterialForm
    {
        #region variables
        private Configuration config;
        private ControlList controlList;
        #endregion

        public MainInterfacefrm()
        {
            #region initialise
            InitializeComponent();
            try
            {
                config = FileOperator.ReadConfig("path"); // insert right path or get from Filedialog
            }
            catch (Exception ex)
            {
                MessageBox.Show("Konfiguration konnte nicht gelesen werden.\nStandardkonfiguration wurde erstellt");
                config = new Configuration();
                config.EnginePause = 20;

                // add standard positions
            }
            controlList = new ControlList();
            #endregion

            #region apearance
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Orange400, Primary.Orange800,
                Primary.Orange500, Accent.DeepOrange700,
                TextShade.WHITE);
            #endregion
        }

        private void Form1_Load (object sender, EventArgs e)
        {

        }
    }
}
