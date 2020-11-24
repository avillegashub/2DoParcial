using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    public class Delivery : Pedido,  IFormater
    {
        bool estado;

        public bool Estado { get => estado; set => estado = value; }

        public Delivery(Cliente cliente, List<Producto> productos):base(productos, cliente)
        {
            Estado = false;
        }
        public Delivery():base()
        {

        }

        public override string FormatearTexto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ORDEN NRO: {this.Orden}");
            sb.AppendLine($"------------------------------------------------");
            sb.AppendLine(this.Cliente.FormatearTexto());
            sb.AppendLine("----------------------ORDEN----------------------");
            sb.AppendLine(base.FormatearTexto());
            sb.AppendLine($"------------------------------------------------");
            sb.AppendLine($"DIRECCION ENTREGA: {this.Cliente.Direccion}");
            return sb.ToString();
        }


    }
}
