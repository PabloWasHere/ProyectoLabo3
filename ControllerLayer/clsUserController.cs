using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using DataLayer;

namespace ControllerLayer
{
    class clsUserController
    {
        clsUserManajer userMan;

        public void clsUserManajer(string user, string password)
        {
            userMan = new clsUserManajer(user, password);
        }

        public entUsuario login(string user, string password)
        {

        }
    }
}
