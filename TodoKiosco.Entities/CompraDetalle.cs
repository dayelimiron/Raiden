using System;

namespace TodoKiosco.Entities
{
    public class CompraDetalle
    {
        public int CompraDetalleId {get;set;}
        public int CompraId {get;set;}
        public string DenominacionId {get;set;}
        public int Cantidad {get;set;}
        public decimal Subtotal {get;set;}
    }
}
