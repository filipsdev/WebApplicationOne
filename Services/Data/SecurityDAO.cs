using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplicationOne.Models;

namespace WebApplicationOne.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(UserModel user)
        {
            return (user.Username == "Admin" && user.Password == "Secret");
        }
    }
}