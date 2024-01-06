using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.Models
{

    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(Guid id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public User() {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Email} ";
        }
    }
}
