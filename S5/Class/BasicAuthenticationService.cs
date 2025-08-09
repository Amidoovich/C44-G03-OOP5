using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S5.Interface;

namespace S5.Class
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        #region Properties

        private string UserName = "Samy@";
        private string Password = "1234";
        private string Role = "Admin";


        #endregion
        public bool AuthenticateUser(string? username, string? password)
        {
            if(username is not null && password is not null )
                if(UserName == username && Password == password)
                    return true;
            return false;
            
        }

        public bool AuthorizeUser(string? username , string? role)
        {
            if(username is not null && Role is not null)
                if(UserName == username && Role == role) 
                    return true;
            return false;
        }
    }
}
