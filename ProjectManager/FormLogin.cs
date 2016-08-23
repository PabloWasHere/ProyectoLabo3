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

        private void slideToDestination(Control destination, Control control, int delay, Action onFinish)
        {
            new Task(() =>
            {
                int directionX = destination.Left > control.Left ? 1 : -1;
                int directionY = destination.Top > control.Top ? 1 : -1;

                while (control.Left != destination.Left || control.Top != destination.Top)
                {
                    try
                    {
                        if (control.Left != destination.Left)
                        {
                            this.Invoke((Action)delegate()
                            {
                                control.Left += directionX;
                            });
                        }
                        if (control.Top != destination.Top)
                        {
                            this.Invoke((Action)delegate()
                            {
                                control.Top += directionY;
                            });
                        }
                        Thread.Sleep(delay);
                    }
                    catch
                    {
                        // form could be disposed
                        break;
                    }
                }

                if (onFinish != null) onFinish();

            }).Start();
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
            slideToDestination(sender as Control, signControl, 0, null);
        }

        
    }
}
