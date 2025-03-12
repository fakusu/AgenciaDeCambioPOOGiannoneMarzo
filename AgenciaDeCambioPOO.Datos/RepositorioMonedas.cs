using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioMonedas
    {
        private readonly string? _ruta;
        private readonly IArchivo<Moneda>? _manejadorXml;

        private Dictionary<string, Moneda> monedas = new();

        public RepositorioMonedas(string ruta, IArchivo<Moneda> manejadorXml)
        {
            _ruta = ruta;
            _manejadorXml = manejadorXml;
            CargarMonedas();
        }

        private void CargarMonedas()
        {
            var lista = _manejadorXml.LeerDatos(_ruta);
        }
        public List<Moneda> ObtenerTodas()
        {
            return monedas.Values.ToList();
        }
        public string ActualizarDivisa(Divisa moneda)
        {
            return $"";
        }

        private void GuardarMonedas (List<Moneda> monedas)
        {
            var monedaBuscada = BuscarMoneda(monedas.);
            if (monedaBuscada == null)
            {
                monedas.Add(monedas.Abreviatura, monedas);
            }
            else
            {
                monedaBuscada.CotizacionCompra = monedas.CotizacionCompra;
                monedaBuscada.CotizacionVenta = monedas.CotizacionVenta;
                monedaBuscada.Cantidad = monedas.Cantidad;
            }
            GuardarDatos();
        }

        private Moneda BuscarMoneda(string abreviatura )
        {
            monedas.TryGetValue(abreviatura, out Moneda? buscarMoneda);
            return buscarMoneda;
        }

        private void GuardarDatos()
        {
            _manejadorXml.GuardarDatos(_ruta, monedas.Values.ToList());
        }
    }
}
