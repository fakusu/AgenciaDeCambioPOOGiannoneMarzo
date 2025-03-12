using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
      public interface IArchivo<Moneda>
    {
         void GuardarDatos(string ruta, List<Moneda> datos);
         List<Moneda> LeerDatos(string ruta);
    }
}
