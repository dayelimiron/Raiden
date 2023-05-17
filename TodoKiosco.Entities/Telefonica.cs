using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoKiosco.Entities
{
    public class Telefonica
    {
        public int TelefonicaId { get; set; }
        public string Nombre { get; set; }

        public Telefonica()
        {

        }

        public Telefonica(string nombre)
        {
            Nombre = nombre;
        }

        public Telefonica(int telefonicaId, string nombre)
        {
            TelefonicaId = telefonicaId;
            Nombre = nombre;
        }
    }
}
