using Kitapsec.Core;
using Kitapsec.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapsec.Service
{
    public class UserService
    {
        KitapsecDbContext Database = new KitapsecDbContext();
        public bool Register(User user)
        {
            bool isRegisterSuccessful = false;

            try
            {
                Database.Users.Add(user);
                Database.SaveChanges();
                isRegisterSuccessful = true;
            }
            catch (Exception ex)
            {

                throw;
            }

            return isRegisterSuccessful;
        }

 
    }

    public enum CustomSignInStatus
    {
        Success,
        LockedOut,
        RequiresVerification,
        Failure
    }
}
