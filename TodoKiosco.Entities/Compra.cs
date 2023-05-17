using System;

namespace TodoKiosco.Entities
{
    public class Compra
    {
        public int CompraId {get;set;}
        public DateTime Fecha {get;set;}
        public decimal Total {get;set;}
        public int ProveedorId {get;set;}
        public string Email {get;set;}
    }
}
