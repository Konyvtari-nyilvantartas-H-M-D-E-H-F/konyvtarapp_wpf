using konyvtarMVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtarMVVM.Service.SchoolCitizens
{
    public interface IBookService
    {
        public Task<List<Book>> SelectAllBook();
    }
}
