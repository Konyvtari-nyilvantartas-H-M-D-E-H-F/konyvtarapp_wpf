using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvtarMVVM.Models
{
    public class Kiado
    {
        public Guid Id { get; set; }
        public string FirmName { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

        public Kiado(Guid id, string firmName, string country, string email)
        {
            Id = id;
            FirmName = firmName;
            Country = country;
            Email = email;
        }

        public Kiado()
        {
            Id = Guid.NewGuid();
            FirmName = string.Empty;
            Country = string.Empty;
            Email = string.Empty;
        }

        public override string ToString()
        {
            return $"{FirmName} {Country} {Email} ";
        }
    }
}
