using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Classes;
using ControllerLayer;

namespace ProjectManager
{
    public partial class FormLogin : Form
    {
        clsUserController userCon = new clsUserController();

        public FormLogin()
        {
            InitializeComponent();
            //masterDetailButtonList1.addItem(new ControlLibrary.MasterDetailItem());
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void logControl_Load(object sender, EventArgs e)
        {

        }

        private void logControl_SignupLinkClick(object sender, EventArgs e)
        {
            ///logControl.Visible = false;
            Util.slideToDestination(this, sender as Control, signControl, 0, null);
        }

        private void logControl_LoginButtonClick(object sender, EventArgs e)
        {
            entUsuario user = new entUsuario();

            try
            {
                user = userCon.Login(logControl.UserText, logControl.PasswordText);

                Session.User = user;

                new FormProfile().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                logControl.UserText = "";
                logControl.PasswordText = "";
            }
        }

        private void signControl_SignupButtonClick(object sender, EventArgs e)
        {
            entUsuario user;

            try
            {
                user = userCon.Signup(signControl.UserText, signControl.PasswordText);
                Session.User = user;

                new FormProfile().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
