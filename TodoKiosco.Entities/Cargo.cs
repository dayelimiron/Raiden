using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoKiosco.Entities
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nombre { get; set; }

        public Cargo()
        {

        }

        public Cargo(string nombre)
        {
            Nombre = nombre;
        }

        public Cargo(int cargoId, string nombre)
        {
            CargoId = cargoId;
            Nombre = nombre;
        }
    }
}
