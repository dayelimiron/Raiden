using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoKiosco.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {           
        }

        public Cliente(string nombre, string apellido, string dui, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Telefono = telefono;
        }

        public Cliente(int clienteId, string nombre, string apellido, string dui, string telefono)
        {
            ClienteId = clienteId;
            Nombre = nombre;
            Apellido = apellido;
            DUI = dui;
            Telefono = telefono;
        }
    }
}
