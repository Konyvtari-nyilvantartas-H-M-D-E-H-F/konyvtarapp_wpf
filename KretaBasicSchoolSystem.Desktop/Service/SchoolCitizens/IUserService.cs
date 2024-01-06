using KretaBasicSchoolSystem.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens
{
    public interface IUserService
    {
        public Task<List<User>> SelectAllUser();
       
    }
}
