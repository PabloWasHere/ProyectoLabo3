using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entGrupo
    {
        private int idGrupo;

        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string informacion;

        public string Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }

        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private int nIntegrantes;

        public int NIntegrantes
        {
            get { return nIntegrantes; }
            set { nIntegrantes = value; }
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
    }
}
