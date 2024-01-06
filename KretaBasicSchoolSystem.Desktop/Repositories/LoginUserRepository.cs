using KretaBasicSchoolSystem.Desktop.Models;
using System;
using System.Net;

namespace KretaBasicSchoolSystem.Desktop.Repositories
{
    public class UserRepository
    {
        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser = true;
            return validUser;
        }

        public LoginUser? GetByUsername(string userName)
        {
             return new LoginUser
             {
                 Username = "teszt",
                 Email = "teszt@teszt.hu",
                 FirstName = "Elek",
                 LastName = "Teszt",
                 Password = "test@123"
             };
        }
    }
}
