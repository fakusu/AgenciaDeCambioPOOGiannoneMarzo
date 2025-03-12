using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
    public class Divisa : Moneda
    {

        public decimal CotizacionCompra { get; set; }
        public decimal CotizacionVenta { get; set; }

        public Divisa()
        {
            
        }

        public Divisa(Moneda moneda,string nombre,string abreviatura,  decimal cantidad, decimal cotizacionCompra,decimal cotizacionVenta):base(nombre,abreviatura,moneda.Cantidad)
        {
            ObtenerValorEnPesos(moneda);
            CotizacionCompra = cotizacionCompra;
            CotizacionVenta = cotizacionVenta;
        }
        public  override decimal ObtenerValorEnPesos(Moneda moneda)
        {
            return CotizacionCompra * Cantidad;
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos()+$" - Cotizacion Compra:{CotizacionCompra} - Cotizacion Venta:{CotizacionVenta}";
        }
    }
}
