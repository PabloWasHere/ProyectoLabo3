using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using ControllerLayer;

namespace ProjectManager
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            lblName.Text = Session.User.Nombre;
            lblLevel.Text = Session.User.Nivel.ToString();
            lblExp.Text = Session.User.Experiencia.ToString() + "/" + Session.User.getExpNeeded(Session.User.Nivel + 1).ToString();

        }
    }
}
