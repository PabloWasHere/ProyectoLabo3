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

        private int idGrupo;

        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        private int idPaso;

        public int IdPaso
        {
            get { return idPaso; }
            set { idPaso = value; }
        }
    }
}
