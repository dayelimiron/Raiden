using System;

namespace TodoKiosco.Entities
{
    public class VentaDetalle
    {
        public int VentaDetalleId {get;set;}
        public int VentaId {get;set;}
        public string DenominacionId {get;set;}
        public int Cantidad {get;set;}
        public decimal Subtotal {get;set;}
    }
}
