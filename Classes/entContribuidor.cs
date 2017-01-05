using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entContribuidor
    {
        private entUsuario usuario;

        public entUsuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private entProyecto proyecto;

        public entProyecto Proyecto
        {
            get { return proyecto; }
            set { proyecto = value; }
        }
    }
}
