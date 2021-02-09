using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationOne.Models;
using WebApplicationOne.Services.Data;

namespace WebApplicationOne.Services.Business
{
    // This class checks if a user is real or not
    public class SecurityService
    {

        SecurityDAO daoService = new SecurityDAO();

        public bool Authenticate(UserModel user)
        {
            // Goes to the DB and if it finds the user it returns a true value
            return daoService.FindByUser(user);
        }


    }
}