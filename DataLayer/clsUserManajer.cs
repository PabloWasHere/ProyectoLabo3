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
        clsGroupManager groupMan;

        public clsUserManajer(string user, string password)
        {
            if(user == null || password == null)
            {
                dbMan = new clsDBManager("", "");
                groupMan = new clsGroupManager("", "");
            }
            else
            {
                dbMan = new clsDBManager(user, password);
                groupMan = new clsGroupManager(user, password);
            }
        }

        public void createAccount(string user, string pass, AccountType acc)
        {
            entUsuario userInstance;

            try
            {
                userInstance = getUserByName(user);

                if(userInstance != null)
                {
                    throw new Exception("Ese nombre de usuario ya existe.");
                }
                else
                {
                    dbMan.createAccount(user, pass, acc);
                }
            }
            catch (Exception e) 
            {
                throw e;
            }

            dbMan = new clsDBManager(user, pass);
        }

        public entUsuario login(string user, string password)
        {
            entUsuario userInstance;

            try
            {
                userInstance = getUserByNameAndPassword(user, password);
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

        public entUsuario getUserByNameAndPassword(string name, string password)
        {
            DataTable data = new DataTable();
            entUsuario user = new entUsuario();

            try
            {
                data = dbMan.search("select * from usuario where activo = 1 and nombre = '" + name + "', and contrasena = '" + password + "'");
            }
            catch (Exception e)
            {
                throw e;
            }

            user.IdUsuario = Convert.ToInt32(data.Rows[0]["idUsuario"]);
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

        public entUsuario getUserByName(string name)
        {
            DataTable data = new DataTable();
            entUsuario user = new entUsuario();

            try
            {
                data = dbMan.search("select * from usuario where activo = 1 and nombre = '" + name + "'");
            }
            catch (Exception e)
            {
                throw e;
            }

            user.IdUsuario = Convert.ToInt32(data.Rows[0]["idUsuario"]);
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

        public int UpdateUser(entUsuario user)
        {
            int rows;
            try
            {
                string query = "UPDATE Usuario Set nombre = '" + user.Nombre + "', contrasena = '" + user.Contrasena + "', bio = '" + user.Bio + "', especialidades = '" + user.Especialidades + "', nProyectosActuales = '" + user.NProyectosActuales + "', nContribuciones = " + user.NContribuciones + ", nivel = '" + user.Nivel + "', experiencia = '" + user.Experiencia + "', categoriaA = '" + user.CategoriaA + "', categoriaB = '" + user.CategoriaB + "', categoriaC = '" + user.CategoriaC + "', categoriaD = '" + user.CategoriaD + "', categoriaF = '" + user.CategoriaF + "', categoria = '" + user.Categoria + "', tipo = '" + user.Tipo + "', activo = '" + user.Activo + "', idGrupo = '" + user.Grupo + "' WHERE idUsuario =" + user.IdUsuario + ";";
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
                dt = dbMan.search("SELECT * FROM Usuario;");
            }
            catch (Exception e)
            {
                throw e;
            }

            foreach (DataRow dr in dt.Rows)
            {
                entUsuario a = new entUsuario();

                a.IdUsuario = Convert.ToInt32(dr["idUsuario"]);
                a.Nombre = Convert.ToString(dr["nombre"]);
                a.Contrasena = Convert.ToString(dr["contrasena"]);
                a.Bio = Convert.ToString(dr["bio"]);
                a.Especialidades = Convert.ToString(dr["especialidades"]);
                a.NProyectosActuales = Convert.ToInt32(dr["nProyectosActuales"]);
                a.NContribuciones = Convert.ToInt32(dr["nContribuciones"]);
                a.Nivel = Convert.ToInt32(dr["nivel"]);
                a.Experiencia = Convert.ToInt32(dr["experiencia"]);
                a.CategoriaA = Convert.ToInt32(dr["categoriaA"]);
                a.CategoriaB = Convert.ToInt32(dr["categoriaB"]);
                a.CategoriaC = Convert.ToInt32(dr["categoriaC"]);
                a.CategoriaD = Convert.ToInt32(dr["categoriaD"]);
                a.CategoriaF = Convert.ToInt32(dr["categoriaF"]);
                a.Tipo = Convert.ToString(dr["tipo"]);
                a.Activo = Convert.ToInt32(dr["activo"]) == 1;
                a.Grupo = groupMan.getGrupo(Convert.ToInt32(dr["idGrupo"]));
                a.Categoria = Convert.ToChar(dr["categoria"]);

                list.Add(a);
            }

            return list;
        }

        public List<entUsuario> getContribuidores(int idProyecto)
        {
            throw new NotImplementedException();
        }
    }
}
