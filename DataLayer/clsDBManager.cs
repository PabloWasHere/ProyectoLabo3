﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Interfaces;

namespace DataLayer
{
    public class clsDBManager
    {
        SqlConnection cnn;

        SqlCommand cmd;

        SqlTransaction transaction;

        string strcnn;
        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        string server = "PABLO-PC\\SQLEXPRESS";

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        string dataBase = "ProjectManager";

        public string DataBase
        {
            get { return dataBase; }
            set { dataBase = value; }
        }

        public clsDBManager(string user, string password)
        {
            this.user = user;
            this.password = password;

            cnn = new SqlConnection();
            cnn.ConnectionString = connectionString();
        }

        public string connectionString()
        {
            if ((user == "" || user == null) || (password == "" || password == null))
            {
                strcnn = "Data Source=" + server + ";Initial Catalog=" + dataBase + ";Integrated Security=True";
            }
            else
            {
                strcnn = "Data Source=" + server + ";Initial Catalog=" + dataBase + ";User ID=" + User + ";Password=" + Password;
            }

            return strcnn;
        }

        private SqlConnection getConnection()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return cnn;
        }

        public void createAccount(string username, string password, AccountType acc)
        {
            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "CREATE LOGIN " + username + " WITH PASSWORD = '" + password + "';";
            cmd.CommandTimeout = 10;

            try
            {
                cmd.Connection = getConnection();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "CREATE USER " + username + " FOR LOGIN " + username + ";";
                cmd.ExecuteNonQuery();

                if (acc == AccountType.ADMIN)
                {
                    cmd.CommandText = "INSERT INTO Usuario (usuario, contrasena, tipo, nivel, nombre, nProyectosActuales, nContribuciones, experiencia, categoriaA, categoriaB, categoriaC, categoriaD, categoriaF, activo) VALUES ('" + username + "', '" + password + "', A, 0, '" + username + "' 0, 0, 0, 0, 0, 0, 0, 0, 1); GRANT SELECT, INSERT, UPDATE, DELETE TO " + username + ";";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText += "INSERT INTO usuario (usuario, contrasena, tipo, nivel, nombre, nProyectosActuales, nContribuciones, experiencia, categoriaA, categoriaB, categoriaC, categoriaD, categoriaF, activo) VALUES ('" + username + "', '" + password + "', N, 0, '" + username + "' 0, 0, 0, 0, 0, 0, 0, 0, 1); GRANT SELECT, INSERT, UPDATE TO " + username + ";";
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }
        }

        public int execute(string query, QueryType action)
        {
            int valor;

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.CommandTimeout = 10;

            try
            {
                cmd.Connection = getConnection();
                if (action == QueryType.UPDATE || action == QueryType.DELETE)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText += ";SELECT SCOPE_IDENTITY();";
                    valor = Convert.ToInt32(cmd.ExecuteScalar());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return valor;

        }

        public DataTable search(string query)
        {
            DataTable dt = new DataTable();

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
            cmd.CommandTimeout = 10;

            try
            {
                cmd.Connection = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return dt;
        }


        public int execute(string procedure, SqlParameter[] param, QueryType action)
        {
            int valor;

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = procedure;
            cmd.Parameters.AddRange(param);
            cmd.CommandTimeout = 10;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            try
            {
                cmd.Connection = getConnection();
                if (action == QueryType.UPDATE || action == QueryType.DELETE)
                {
                    valor = cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    valor = Convert.ToInt32(returnParameter.Value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return valor;
        }

        public DataTable search(string procedure, SqlParameter[] param)
        {
            DataTable dt = new DataTable();

            cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = procedure;
            cmd.Parameters.AddRange(param);
            cmd.CommandTimeout = 10;


            try
            {
                cmd.Connection = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.FillSchema(dt, SchemaType.Source);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cnn.Close();
            }

            return dt;
        }
    }
}
