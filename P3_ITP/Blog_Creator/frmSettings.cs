/**
 * author:      Fragner Julian
 * class:       4aHIT 1718
 * project:     P02 - RemoteControl
 * purpose:    Receives Text from an FTP-Server and passes it to an microcontroller
*/

using MaterialSkin.Controls;
using System;
using System.Drawing;

namespace Blog_Creator
{
    public partial class frmSettings : MaterialForm
    {
        #region Constructor
        public frmSettings()
        {
            InitializeComponent();
            resetForm();
        }
        #endregion

        #region PrivateFields
        private string user;
        private string password;
        #endregion

        #region Properties
        public string User
        {
            get
            {
                return user;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
        }
        #endregion

        #region Functions
        private void closeForm()
        {
            this.Close();
        }

        public void resetForm()
        {
            txtPassw.Text = "";
            txtUser.Text = "anonymous";
        }
        #endregion

        #region Events
        private void cmdCancelSettings_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void frmSettings_VisibleChanged(object sender, EventArgs e)
        {
            txtUser.Text = user;
            txtPassw.Text = password;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtPassw.ForeColor = Color.Black;
            txtUser.ForeColor = Color.Black;
        }

        private void cmdSaveSettings_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                user = "anonymous";
            }
            else
            {
                user = txtUser.Text;
            }
            password = txtPassw.Text;
            closeForm();
        }
        #endregion
    }
}
