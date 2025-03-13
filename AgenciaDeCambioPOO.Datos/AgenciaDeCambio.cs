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
        private readonly RepositorioMonedas _repositorio;

        public AgenciaDeCambio(RepositorioMonedas repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Moneda> ObtenerTodas()
        {
            return _repositorio.ObtenerTodas();
        }


    }
 }
