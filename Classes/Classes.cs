using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Contribuidor
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

    public class Grupo
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

        private int idLider;

        public int IdLider
        {
            get { return idLider; }
            set { idLider = value; }
        }
    }

    public class Notificacion
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

    public class Paso
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

        private int idProyecto;

        public int IdProyecto
        {
            get { return idProyecto; }
            set { idProyecto = value; }
        }
    }

    public class Proyecto
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

        private int idLider;

        public int IdLider
        {
            get { return idLider; }
            set { idLider = value; }
        }
    }

    public class Usuario
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

        private int idGrupo;

        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }
    }
}
