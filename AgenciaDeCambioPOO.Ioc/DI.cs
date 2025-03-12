﻿using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Ioc
{
  public static  class DI
    {
        public static IServiceProvider ConfigurarDI()
        {
            var services = new ServiceCollection();
            
            services.AddSingleton<IArchivo<Moneda>,ManejadorXML>();
            services.AddSingleton(provider =>
               new RepositorioMonedas("NuevasDivisas.xml",
                   provider.GetRequiredService<IArchivo<Moneda>()));

            return services.BuildServiceProvider();
        }
    }
}
