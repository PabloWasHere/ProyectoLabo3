using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entProyecto
    {
        private int idProyecto;

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private DateTime deadline;

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        private int maxContribuidores;

        public int MaxContribuidores
        {
            get { return maxContribuidores; }
            set { maxContribuidores = value; }
        }

        private int dificultad;

        public int Dificultad
        {
            get { return dificultad; }
            set { dificultad = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private entUsuario lider;

        public entUsuario Lider
        {
            get { return lider; }
            set { lider = value; }
        }

        private List<entUsuario> contribuidores;

        public List<entUsuario> Contribuidores
        {
            get { return contribuidores; }
            set { contribuidores = value; }
        }
    }
}
