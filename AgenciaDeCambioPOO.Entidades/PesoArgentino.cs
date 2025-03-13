using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
    public class PesoArgentino : Moneda
        
    {
        public decimal Valor { get; set; }
        public PesoArgentino(decimal valor)
        {
            Valor = valor;
        }
        public PesoArgentino(Moneda moneda,string nombre,string abreviatura, decimal cantidad):base(nombre,abreviatura,moneda.Cantidad)
        {

        }
        

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"- No tiene cotizaciones!! -";
        }

        public override decimal ObtenerValorEnPesos()
        {
            return Cantidad  ;
        }
    }
}
