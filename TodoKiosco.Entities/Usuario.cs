using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoKiosco.Entities
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int EmpleadoId { get; set; }
        public int RolId { get; set; }

        public Usuario()
        {

        }

        public Usuario(string password, int empleadoId, int rolId)
        {
            Password = password;
            EmpleadoId = empleadoId;
            RolId = rolId;
        }

        public Usuario(string email, string password, int empleadoId, int rolId)
        {
            Email = email;
            Password = password;
            EmpleadoId = empleadoId;
            RolId = rolId;
        }
    }
}
