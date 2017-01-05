using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Classes;

namespace DataLayer
{
    class clsProjectManager
    {
        clsDBManager dbMan;
        clsUserManajer userMan;

        public clsProjectManager(string user, string password)
        {
            if(user == null || password == null)
            {
                dbMan = new clsDBManager("", "");
                userMan = new clsUserManajer("", "");
            }
            else
            {
                dbMan = new clsDBManager(user, password);
                userMan = new clsUserManajer(user, password);
            }
        }

        public List<entProyecto> getProyectosByUser(entUsuario user)
        {
            DataTable data = new DataTable();
            DataTable data2 = new DataTable();
            List<entProyecto> proyectos = new List<entProyecto>();

            try
            {
                data = dbMan.search("select * from proyecto where activo = 1 and idLider = " + user.IdUsuario);
            }
            catch (Exception e)
            {
                throw e;
            }

            entProyecto p;

            foreach (DataRow dr in data.Rows)
            {
                p = new entProyecto();
                p.IdProyecto = Convert.ToInt32(data.Rows[0]["idProyecto"]);
                p.Nombre = Convert.ToString(data.Rows[0]["nombre"]);
                p.Contribuidores = userMan.getContribuidores(p.IdProyecto);
                p.Activo = Convert.ToInt32(data.Rows[0]["activo"]) == 1;
                p.Deadline = Convert.ToDateTime(data.Rows[0]["deadline"]);
                p.Descripcion = Convert.ToString(data.Rows[0]["descripcion"]);
                p.Dificultad = Convert.ToInt32(data.Rows[0]["dificultad"]);
                p.Lider = userMan.getUser(Convert.ToInt32(dr["idLider"]));
                p.MaxContribuidores = Convert.ToInt32(dr["maxContribuidores"]);

                proyectos.Add(p);
            }

            return proyectos;
        }
    }
}
