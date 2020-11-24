using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Funcionalidad

{
    public class Xml<T> 
    {
        
            static public bool Guardar(T datos, string file)
            {
                try
                {
                    using (XmlTextWriter writer = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + file, System.Text.Encoding.UTF8))
                    {
                        Type asd = datos.GetType();
                        XmlSerializer ser = new XmlSerializer(datos.GetType());
                        ser.Serialize(writer, datos);
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
         

            
            public static T Leer( string file )
            {
                try
                {
                using (var reader = new StreamReader(file))
                {
                    XmlSerializer deserializer = new XmlSerializer(typeof(T));
                    return (T)deserializer.Deserialize(reader);
                }
                }
                catch (Exception)
                {
                    throw new Exception("Error en Carga XML");
                }
            }



        
    }
}
