using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entContribuidor
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private int idProyecto;

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }
    }
}
