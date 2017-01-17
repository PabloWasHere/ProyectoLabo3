using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Classes;
using System.Data;

namespace DataLayer
{
    public class clsUserManajer
    {
        clsDBManager dbMan;
        clsGroupManager groupMan = new clsGroupManager();
        clsProjectManager projectMan = new clsProjectManager();

        public clsUserManajer()
        {
            dbMan = new clsDBManager(Session.User.Usuario, Session.User.Contrasena);
        }

        public entUsuario createAccount(string user, string pass, AccountType acc)
        {
            entUsuario userInstance;

            try
            {
                userInstance = getUserByUsuario(user);

                if(userInstance != null)
                {
                    throw new Exception("Ese nombre de usuario ya existe.");
                }
                else
                {
                    dbMan.createAccount(user, pass, acc);
                    userInstance = getUserByUsuarioAndPassword(user, pass);
                }
            }
            catch (Exception e) 
            {
                throw e;
            }

            dbMan = new clsDBManager(user, pass);
            Session.User = userInstance;

            return userInstance;
        }

        public entUsuario login(string user, string password)
        {
            entUsuario userInstance;

            try
            {
                userInstance = getUserByUsuarioAndPassword(user, password);
                if (userInstance == null)
                {
                    throw new Exception("El usuario ingresado no existe.");
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return userInstance;
        }

        public entUsuario getUserByUsuarioAndPassword(string userName, string password)
        {
            DataTable data = new DataTable();
            entUsuario user = new entUsuario();

            try
            {
                data = dbMan.search("select * from usuario where activo = 1 and usuario = '" + userName + "', and contrasena = '" + password + "'");
            }
            catch (Exception e)
            {
                throw e;
            }

            user.IdUsuario = Convert.ToInt32(data.Rows[0]["idUsuario"]);
            user.Usuario = Convert.ToString(data.Rows[0]["usuario"]);
            user.Nombre = Convert.ToString(data.Rows[0]["nombre"]);
            user.Contrasena = Convert.ToString(data.Rows[0]["contrasena"]);
            user.Activo = Convert.ToInt32(data.Rows[0]["activo"]) == 1;
            user.Bio = Convert.ToString(data.Rows[0]["bio"]);
            user.Categoria = Convert.ToChar(data.Rows[0]["categoria"]);
            user.CategoriaA = Convert.ToInt32(data.Rows[0]["categoriaA"]);
            user.CategoriaB = Convert.ToInt32(data.Rows[0]["categoriaB"]);
            user.CategoriaC = Convert.ToInt32(data.Rows[0]["categoriaC"]);
            user.CategoriaD = Convert.ToInt32(data.Rows[0]["categoriaD"]);
            user.CategoriaF = Convert.ToInt32(data.Rows[0]["categoriaF"]);
            user.Especialidades = Convert.ToString(data.Rows[0]["especialidades"]);
            user.Experiencia = Convert.ToInt32(data.Rows[0]["experiencia"]);
            user.Grupo = groupMan.getGrupo(Convert.ToInt32(data.Rows[0]["idGrupo"]));
            user.NContribuciones = Convert.ToInt32(data.Rows[0]["nContribuciones"]);
            user.Nivel = Convert.ToInt32(data.Rows[0]["nivel"]);
            user.NProyectosActuales = Convert.ToInt32(data.Rows[0]["nProyectosActuales"]);
            user.Proyectos = projectMan.getProjectsByUser(user.IdUsuario);
            user.Tipo = Convert.ToString(data.Rows[0]["tipo"]);

            return user;
        }

        public entUsuario getUser(int id)
        {
            DataTable data = new DataTable();
            entUsuario user = new entUsuario();

            try
            {
                data = dbMan.search("select * from usuario where activo = 1 and id = " + id);
            }
            catch (Exception e)
            {
                throw e;
            }

            user.IdUsuario = Convert.ToInt32(data.Rows[0]["idUsuario"]);
            user.Usuario = Convert.ToString(data.Rows[0]["usuario"]);
            user.Nombre = Convert.ToString(data.Rows[0]["nombre"]);
            user.Contrasena = Convert.ToString(data.Rows[0]["contrasena"]);
            user.Activo = Convert.ToInt32(data.Rows[0]["activo"]) == 1;
            user.Bio = Convert.ToString(data.Rows[0]["bio"]);
            user.Categoria = Convert.ToChar(data.Rows[0]["categoria"]);
            user.CategoriaA = Convert.ToInt32(data.Rows[0]["categoriaA"]);
            user.CategoriaB = Convert.ToInt32(data.Rows[0]["categoriaB"]);
            user.CategoriaC = Convert.ToInt32(data.Rows[0]["categoriaC"]);
            user.CategoriaD = Convert.ToInt32(data.Rows[0]["categoriaD"]);
            user.CategoriaF = Convert.ToInt32(data.Rows[0]["categoriaF"]);
            user.Especialidades = Convert.ToString(data.Rows[0]["especialidades"]);
            user.Experiencia = Convert.ToInt32(data.Rows[0]["experiencia"]);
            user.Grupo = groupMan.getGrupo(Convert.ToInt32(data.Rows[0]["idGrupo"]));
            user.NContribuciones = Convert.ToInt32(data.Rows[0]["nContribuciones"]);
            user.Nivel = Convert.ToInt32(data.Rows[0]["nivel"]);
            user.NProyectosActuales = Convert.ToInt32(data.Rows[0]["nProyectosActuales"]);
            user.Proyectos = projectMan.getProjectsByUser(user.IdUsuario);
            user.Tipo = Convert.ToString(data.Rows[0]["tipo"]);

            return user;
        }

        public entUsuario getUserByUsuario(string user)
        {
            DataTable data = new DataTable();
            entUsuario userInstance = new entUsuario();

            try
            {
                data = dbMan.search("select * from usuario where activo = 1 and usuario = '" + user + "'");
            }
            catch (Exception e)
            {
                throw e;
            }

            userInstance.IdUsuario = Convert.ToInt32(data.Rows[0]["idUsuario"]);
            userInstance.Nombre = Convert.ToString(data.Rows[0]["nombre"]);
            userInstance.Contrasena = Convert.ToString(data.Rows[0]["contrasena"]);
            userInstance.Activo = Convert.ToInt32(data.Rows[0]["activo"]) == 1;
            userInstance.Bio = Convert.ToString(data.Rows[0]["bio"]);
            userInstance.Categoria = Convert.ToChar(data.Rows[0]["categoria"]);
            userInstance.CategoriaA = Convert.ToInt32(data.Rows[0]["categoriaA"]);
            userInstance.CategoriaB = Convert.ToInt32(data.Rows[0]["categoriaB"]);
            userInstance.CategoriaC = Convert.ToInt32(data.Rows[0]["categoriaC"]);
            userInstance.CategoriaD = Convert.ToInt32(data.Rows[0]["categoriaD"]);
            userInstance.CategoriaF = Convert.ToInt32(data.Rows[0]["categoriaF"]);
            userInstance.Especialidades = Convert.ToString(data.Rows[0]["especialidades"]);
            userInstance.Experiencia = Convert.ToInt32(data.Rows[0]["experiencia"]);
            userInstance.Grupo = groupMan.getGrupo(Convert.ToInt32(data.Rows[0]["idGrupo"]));
            userInstance.NContribuciones = Convert.ToInt32(data.Rows[0]["nContribuciones"]);
            userInstance.Nivel = Convert.ToInt32(data.Rows[0]["nivel"]);
            userInstance.NProyectosActuales = Convert.ToInt32(data.Rows[0]["nProyectosActuales"]);
            userInstance.Proyectos = projectMan.getProjectsByUser(userInstance.IdUsuario);
            userInstance.Tipo = Convert.ToString(data.Rows[0]["tipo"]);

            return userInstance;
        }

        public int UpdateUser(entUsuario user)
        {
            int rows;
            try
            {
                string query = "UPDATE Usuario Set usuario = '" + user.Usuario + "', nombre = '" + user.Nombre + "', contrasena = '" + user.Contrasena + "', bio = '" + user.Bio + "', especialidades = '" + user.Especialidades + "', nProyectosActuales = '" + user.NProyectosActuales + "', nContribuciones = " + user.NContribuciones + ", nivel = '" + user.Nivel + "', experiencia = '" + user.Experiencia + "', categoriaA = '" + user.CategoriaA + "', categoriaB = '" + user.CategoriaB + "', categoriaC = '" + user.CategoriaC + "', categoriaD = '" + user.CategoriaD + "', categoriaF = '" + user.CategoriaF + "', categoria = '" + user.Categoria + "', tipo = '" + user.Tipo + "', activo = '" + user.Activo + "', idGrupo = '" + user.Grupo.IdGrupo + "' WHERE idUsuario =" + user.IdUsuario + ";";
                rows = dbMan.execute(query, QueryType.UPDATE);
            }
            catch (Exception e)
            {
                throw e;
            }

            return rows;
        }

        public List<entUsuario> GetUsers()
        {

            List<entUsuario> list = new List<entUsuario>();
            DataTable dt;

            try
            {
                dt = dbMan.search("SELECT idUsuario FROM Usuario;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                entUsuario a = new entUsuario();

                a = getUser(Convert.ToInt32(dr["idUsuario"]));

                list.Add(a);
            }

            return list;
        }

        public List<entUsuario> getContribuidores(int idProyecto)
        {
            List<entUsuario> usuarios = new List<entUsuario>();
            DataTable data = new DataTable();

            try
            {
                data = dbMan.search("select idUsuario from contribuidor where idProyecto = " + idProyecto);
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in data.Rows)
            {
                usuarios.Add(getUser(Convert.ToInt32(dr["idUsuario"])));
            }

            return usuarios;
        }
    }
}
