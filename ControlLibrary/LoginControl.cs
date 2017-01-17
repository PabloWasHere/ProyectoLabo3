using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private string userText;

        public string UserText
        {
            get { return userText; }
            set
            {
                userText = value;
                userBox.Text = value;
            }
        }

        private string passwordText;

        public string PasswordText
        {
            get { return passwordText; }
            set
            {
                passwordText = value;
                passwordBox.Text = value;
            }
        }

        public event EventHandler LoginButtonClick;
        public event EventHandler SignupLinkClick;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.LoginButtonClick != null)
                this.LoginButtonClick(this, e);
        }

        private void lnklblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.SignupLinkClick != null)
                this.SignupLinkClick(this, e);
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            userText = (sender as hintTextBox).Text;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordText = (sender as hintTextBox).Text;
        }
    }
}
