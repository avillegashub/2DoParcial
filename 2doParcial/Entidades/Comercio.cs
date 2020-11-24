using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionalidad;

namespace Entidades
{
    public static class Comercio
    {
        public static List<Pedido> ventas;
        public static List<Cliente> clientes;
        public static List<Producto> productos;

        static Comercio()
        {
            ventas = new List<Pedido>();
            clientes = new List<Cliente>();
            productos = new List<Producto>();
            LeerXml();
        }

        public static void GuardaXml()
        {
            Xml<object>.Guardar(ventas, "ventas.xml");
        }
        public static void LeerXml()
        {
             ventas = Xml<List<Pedido>>.Leer("ventas.xml");
        }

        public static void IngresarVenta(object o)
        {
            if ((o as Pedido).Delivery)
            {
                ventas.Add((Delivery)o);
                (o as Delivery).FormatearTexto().PrintTicket();
            }
            else
                ventas.Add((Pedido)o);

        }


    }
}
