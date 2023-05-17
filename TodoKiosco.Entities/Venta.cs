using System;

namespace TodoKiosco.Entities
{
    public class Venta
    {
        public int VentaId {get;set;}
        public DateTime Fecha {get;set;}
        public decimal Total {get;set;}
        public int ClienteId {get;set;}
        public string Email {get;set;}
    }
}
