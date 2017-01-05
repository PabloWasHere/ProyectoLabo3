using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entNotificacion
    {
        private int idNotificacion;

        public int IdNotificacion
        {
            get { return idNotificacion; }
            set { idNotificacion = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

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

        private entGrupo grupo;

        public entGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private entPaso paso;

        public entPaso Paso
        {
            get { return paso; }
            set { paso = value; }
        }
    }
}
