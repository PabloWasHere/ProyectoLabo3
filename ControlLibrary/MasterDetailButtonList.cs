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
    public partial class MasterDetailButtonList : UserControl
    {
        public MasterDetailButtonList()
        {
            InitializeComponent();

            lastItemBot = masterDetailItem1.Bottom;
            lastItemLeft = masterDetailItem1.Left;
        }

        private int lastItemBot;
        private int lastItemLeft;
        private bool firstItem = true;

        private MasterDetailItem pressedItem;

        public MasterDetailItem PressedItem
        {
            get { return pressedItem; }
            set { pressedItem = value; }
        }

        public void addItem(int id, Image image, Image pressedImage, string title, string shortDetail, string fullDetail)
        {
            MasterDetailItem mdi = new MasterDetailItem();
            mdi.Id = id;
            mdi.Title = title;
            mdi.ShortDetail = shortDetail;
            mdi.FullDetail = fullDetail;
            mdi.Image = image;
            mdi.ButtonDownImage = pressedImage;

            arrangeNewItem(mdi);
        }

        public void addItem(MasterDetailItem mdItem)
        {
            arrangeNewItem(mdItem);
        }

        private void arrangeNewItem(MasterDetailItem mdItem)
        {
            if (firstItem)
            {
                masterDetailItem1 = mdItem;
                firstItem = false;
            }
            else
            {
                MasterDetailItem item = mdItem;

                item.Left = lastItemLeft;
                item.Top = lastItemBot + 3;

                lastItemBot = item.Bottom;

                this.Controls.Add(item);
            }
        }

        private void arrangeAllItems()
        {
            firstItem = true;

            foreach (MasterDetailItem mdi in this.Controls)
            {
                if (firstItem && mdi.Visible == true)
                {
                    mdi.Location = new Point(11, 36);
                    lastItemBot = mdi.Bottom;
                    lastItemLeft = mdi.Left;
                    firstItem = false;
                }
                else if(mdi.Visible == true)
                {
                    mdi.Left = lastItemLeft;
                    mdi.Top = lastItemBot + 3;
                    lastItemBot = mdi.Bottom;
                    lastItemLeft = mdi.Left;
                }
            }
        }

        private void masterDetailItem1_Click(object sender, EventArgs e)
        {
            pressedItem = sender as MasterDetailItem;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (MasterDetailItem mdi in this.Controls)
            {
                if(!System.Text.RegularExpressions.Regex.IsMatch(mdi.Title, "^" + tbFilter.Text))
                {
                    mdi.Visible = false;
                }
                else
                {
                    mdi.Visible = true;
                }
            }

            arrangeAllItems();
        }
    }
}
