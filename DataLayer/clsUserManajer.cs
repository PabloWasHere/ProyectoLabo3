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
    class clsUserManajer
    {
        public clsUserManajer(string user, string password)
        {
            this.username = user;
            this.password = password;
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        clsDBManager dbman;

        public void createAccount(AccountType acc)
        {
            dbman = new clsDBManager("","");
            try
            {
                dbman.createAccount(username, password, acc);
            }
            catch (Exception e) 
            {

            }
        }

        public int UpdateUser(entUsuario user)
        {
            dbman = new clsDBManager(username, password);
            int rows;
            try
            {
                string query = "UPDATE Usuario Set nombre = '" + user.Nombre + "', bio = '" + user.Bio + "', especialidades = '" + user.Especialidades + "', nProyectosActuales = '" + user.NProyectosActuales + "', nContribuciones = " + user.NContribuciones + ", nivel = '" + user.Nivel + "', experiencia = '" + user.Experiencia + "', categoriaA = '" + user.CategoriaA + "', categoriaB = '" + user.CategoriaB + "', categoriaC = '" + user.CategoriaC + "', categoriaD = '" + user.CategoriaD + "', categoriaF = '" + user.CategoriaF + "', categoria = '" + user.Categoria + "', tipo = '" + user.Tipo + "', activo = '" + user.Activo + "', idGrupo = '" + user.IdGrupo + "' WHERE idUsuario =" + user.IdUsuario + ";";
                rows = dbman.execute(query, QueryType.UPDATE);
            }
            catch (Exception e)
            {
                throw e;
            }

            return rows;
        }

        public List<entUsuario> GetUsers()
        {
            dbman = new clsDBManager(username, password);

            List<entUsuario> list = new List<entUsuario>();
            DataTable dt;

            try
            {
                dt = dbman.search("SELECT * FROM Usuario;");
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
                a.Activo = Convert.ToBoolean(dr["activo"]);
                a.IdGrupo = Convert.ToInt32(dr["idGrupo"]);
                a.Categoria = Convert.ToChar(dr["categoria"]);

                list.Add(a);
            }

            return list;
        }
    }
}
