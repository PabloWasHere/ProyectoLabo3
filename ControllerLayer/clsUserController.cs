using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using DataLayer;
using Interfaces;

namespace ControllerLayer
{
    public class clsUserController
    {
        clsUserManajer userMan;

        public void clsUserManajer(string user, string password)
        {
            userMan = new clsUserManajer();
        }

        public entUsuario Login(string user, string password)
        {
            entUsuario userInstance;

            try
            {
                userInstance = userMan.login(user, password);
            }
            catch (Exception e)
            {
                throw e;
            }

            return userInstance;
        }

        public entUsuario Signup(string user, string password)
        {
            entUsuario userInstance;

            try
            {
                userInstance = userMan.createAccount(user, password, AccountType.NORMAL);
            }
            catch (Exception e)
            {
                throw e;
            }

            return userInstance;
        }
    }
}
