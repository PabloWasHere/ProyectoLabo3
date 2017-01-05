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
    public partial class MasterDetailItem : UserControl
    {
        public MasterDetailItem()
        {
            InitializeComponent();

            lblTittle.Parent = pbButton;
            lblTittle.BackColor = Color.Transparent;

            lblDetail.Parent = pbButton;
            lblDetail.BackColor = Color.Transparent;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private bool pressed = false;

        public bool Pressed
        {
            get { return pressed; }
            set { pressed = value; }
        }

        private Image image;

        public Image Image
        {
            get { return image; }
            set { image = value;
                pbButton.Image = image;
            }
        }

        private Image buttonDownImage;

        public Image ButtonDownImage
        {
            get { return buttonDownImage; }
            set { buttonDownImage = value; }
        }

        public event EventHandler ItemClick;

        private void pbButton_Click(object sender, EventArgs e)
        {
            if (this.ItemClick != null)
                this.ItemClick(this, e);

            if (!pressed)
            {
                lblDetail.Text = fullDetail;
                pressed = true;
            }
            else
            {
                lblDetail.Text = shortDetail;
                pressed = false;
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string shortDetail;

        public string ShortDetail
        {
            get { return shortDetail; }
            set { shortDetail = value; }
        }

        private string fullDetail;

        public string FullDetail
        {
            get { return fullDetail; }
            set { fullDetail = value; }
        }

        private void pbButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(buttonDownImage != null)
            {
                pbButton.Image = buttonDownImage;
            }
        }

        private void pbButton_MouseUp(object sender, MouseEventArgs e)
        {
            pbButton.Image = image;
        }
    }
}
