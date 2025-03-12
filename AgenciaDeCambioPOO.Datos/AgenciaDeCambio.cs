using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
    public class AgenciaDeCambio
    {
        private readonly RepositorioMonedas _repositorioMonedas;

        public List<Moneda> ObtenerMonedas()
        {
            return _repositorioMonedas.ObtenerTodas();
        }


    }
 }
