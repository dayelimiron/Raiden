using System;

namespace TodoKiosco.Entities
{
    public class Empleado
    {
        public int EmpleadoID {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string DUI {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public DateTime FechaIngreso {get;set;}
        public string Telefono {get;set;}
        public string Direccion {get;set;}
        public string Observaciones {get;set;}
        public int CargoId {get;set;}
    }
}
