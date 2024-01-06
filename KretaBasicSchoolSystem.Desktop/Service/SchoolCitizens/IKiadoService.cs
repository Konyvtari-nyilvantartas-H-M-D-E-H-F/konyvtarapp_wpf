using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using konyvtarMVVM.Models;

namespace konyvtarMVVM.Service.SchoolCitizens
{
    public interface IKiadoService
    {
        public Task<List<Kiado>> SelectAllKiado();
    }
}
