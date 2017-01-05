using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class entUsuario
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
      
        private string bio;

        public string Bio
        {
            get { return bio; }
            set { bio = value; }
        }

        private string especialidades;

        public string Especialidades
        {
            get { return especialidades; }
            set { especialidades = value; }
        }

        private int nProyectosActuales;

        public int NProyectosActuales
        {
            get { return nProyectosActuales; }
            set { nProyectosActuales = value; }
        }

        private int nContribuciones;

        public int NContribuciones
        {
            get { return nContribuciones; }
            set { nContribuciones = value; }
        }

        private int nivel;

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        private int experiencia;

        public int Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }

        private int categoriaA;

        public int CategoriaA
        {
            get { return categoriaA; }
            set { categoriaA = value; }
        }

        private int categoriaB;

        public int CategoriaB
        {
            get { return categoriaB; }
            set { categoriaB = value; }
        }

        private int categoriaC;

        public int CategoriaC
        {
            get { return categoriaC; }
            set { categoriaC = value; }
        }

        private int categoriaD;

        public int CategoriaD
        {
            get { return categoriaD; }
            set { categoriaD = value; }
        }

        private int categoriaF;

        public int CategoriaF
        {
            get { return categoriaF; }
            set { categoriaF = value; }
        }

        private char categoria;

        public char Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        private entGrupo grupo;

        public entGrupo Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        private List<entProyecto> proyectos;

        public List<entProyecto> Proyectos
        {
            get { return proyectos; }
            set { proyectos = value; }
        }
    }
}
