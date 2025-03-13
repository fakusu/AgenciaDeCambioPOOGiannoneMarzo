using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgenciaDeCambioPOO.Datos
{
    public class ManejadorXML : IArchivo<Moneda>
    {
        private static readonly Type[] TiposMonedas = { typeof(Divisa), typeof(PesoArgentino) };

        public List<Moneda> LeerDatos(string ruta)
        {
            if (!File.Exists(ruta)) return new List<Moneda>();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Moneda>), TiposMonedas);
            using (StreamReader reader = new StreamReader(ruta))
            {
                return (List<Moneda>)serializer.Deserialize(reader);
            }
        }

        public void GuardarDatos(string ruta, List<Moneda> datos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Moneda>), TiposMonedas);
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                serializer.Serialize(writer, datos);
            }
        }


    }
}
