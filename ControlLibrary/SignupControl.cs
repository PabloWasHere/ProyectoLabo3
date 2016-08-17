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
    public partial class SignupControl : UserControl
    {
        public SignupControl()
        {
            InitializeComponent();
        }

        private bool usernameHint = true;

        public bool UsernameHint
        {
            get { return usernameHint; }
            set 
            { 
                usernameHint = value;
                this.lblHint.Visible = value;
            }
        }

        private bool EmailField = true;

        public bool EmailField1
        {
            get { return EmailField; }
            set 
            { 
                EmailField = value;
                this.htbMail.Visible = value;
            }
        }

        private bool wrongPassword = false;

        public bool WrongPassword
        {
            get { return wrongPassword; }
            set 
            { 
                wrongPassword = value;
                this.lblWrongPass.Visible = value;
            }
        }

        public event EventHandler SignupButtonClick;

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (htbPass.Text != htbPassRe.Text)
                this.WrongPassword = true;
            else
            {
                this.WrongPassword = false;
                this.SignupButtonClick(this, e);
            }
        }
    }
}
