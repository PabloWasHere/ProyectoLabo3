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
    }
}
