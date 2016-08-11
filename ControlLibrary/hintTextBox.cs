using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class hintTextBox : TextBox
    {
        private bool firstPress = true;

        private string hint = "Hint my filling.";

        public string Hint
        {
            get { return hint; }
            set 
            { 
                hint = value;
                this.Text = value;
            }
        }

        public hintTextBox()
        {
            InitializeComponent();
            this.ForeColor = Color.Gray;
            this.Text = hint;
        }

        private void hintTextBox_Click(object sender, EventArgs e)
        {
            if (firstPress)
            {
                this.Text = "";
                this.ForeColor = Color.Black;
                firstPress = false;
            }
            else
            {
                this.SelectAll();
            }
        }

        private void hintTextBox_Leave(object sender, EventArgs e)
        {
            if(this.Text == "")
            {
                this.Text = hint;
                this.ForeColor = Color.Gray;
                firstPress = true;
            }
        }
    }
}
