using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoKiosco.Entities
{
    public class Proveedor
    {

        public int ProveedorId { get; set; }
        public string NombreEmpresa { get; set; }
        public string NombreContacto { get; set; }
        public string NIT { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Proveedor()
        {

        }

        public Proveedor(string nombreEmpresa, string nombreContacto, string nit, string telefono, string direccion)
        {
            NombreEmpresa = nombreEmpresa;
            NombreContacto = nombreContacto;
            NIT = nit;
            Telefono = telefono;
            Direccion = direccion;
        }

        public Proveedor(int proveedorId, string nombreEmpresa, string nombreContacto, string nit, string telefono, string direccion)
        {
            ProveedorId = proveedorId;
            NombreEmpresa = nombreEmpresa;
            NombreContacto = nombreContacto;
            NIT = nit;
            Telefono = telefono;
            Direccion = direccion;
        }

      



    }
}
