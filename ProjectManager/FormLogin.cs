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

namespace ProjectManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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

        
    }
}
