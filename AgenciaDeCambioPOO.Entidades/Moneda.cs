using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
    public abstract class Moneda
    {
        public string Abreviatura { get; set; }
        public decimal Cantidad { get; set; }
        public  string Nombre { get; set; }

        public Moneda()
        {
            
        }

        public Moneda(string nombre, string abreviatura, decimal cantidad)

        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.Abreviatura = abreviatura;

        }

        public virtual string MostrarDatos()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Moneda: {Nombre}  ({Abreviatura}) - Cantidad: {Cantidad}");
            return sb.ToString();
            
        }
        public abstract decimal ObtenerValorEnPesos(Moneda moneda);
    }
}
