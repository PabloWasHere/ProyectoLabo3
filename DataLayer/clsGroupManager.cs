using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using System.Data;

namespace DataLayer
{
    public class clsGroupManager
    {
        clsDBManager dbMan;
        clsUserManajer userMan = new clsUserManajer();

        public clsGroupManager()
        {
            dbMan = new clsDBManager(Session.User.Usuario, Session.User.Contrasena);
        }

        public entGrupo getGrupo(int id)
        {
            DataTable data = new DataTable();
            entGrupo group = new entGrupo();

            try
            {
                data = dbMan.search("select * from grupo where activo = 1 and id = " + id);
            }
            catch (Exception e)
            {
                throw e;
            }

            group.IdGrupo = Convert.ToInt32(data.Rows[0]["idGrupo"]);
            group.Nombre = Convert.ToString(data.Rows[0]["nombre"]);
            group.Categoria = Convert.ToString(data.Rows[0]["categoria"]);
            group.Activo = Convert.ToInt32(data.Rows[0]["activo"]) == 1;
            group.Informacion = Convert.ToString(data.Rows[0]["informacion"]);
            group.Lider = userMan.getUser(Convert.ToInt32(data.Rows[0]["idLider"]));
            group.NIntegrantes = Convert.ToInt32(data.Rows[0]["nIntegrantes"]);

            return group;
        }
    }
}
