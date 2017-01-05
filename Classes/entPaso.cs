using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entPaso
    {
        private int idPaso;

        public int IdPaso
        {
            get { return idPaso; }
            set { idPaso = value; }
        }

        private int orden;

        public int Orden
        {
            get { return orden; }
            set { orden = value; }
        }

        private int prioridad;

        public int Prioridad
        {
            get { return prioridad; }
            set { prioridad = value; }
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

        private int maxContribuidores;

        public int MaxContribuidores
        {
            get { return maxContribuidores; }
            set { maxContribuidores = value; }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private entProyecto proyecto;

        public entProyecto Proyecto
        {
            get { return proyecto; }
            set { proyecto = value; }
        }
    }
}
