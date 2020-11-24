using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Delivery))]
    [Serializable]
    public class Pedido : IFormater
    {
        int id;
        Cliente cliente;
        List<Producto> productos;
        string orden;
        bool delivery;

        public int Id { get => id; set => id = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public List<Producto> Productos { get => productos; set => productos = value; }
        public string Orden { get => orden; set => orden = value; }
        public bool Delivery { get => delivery; set => delivery = value; }

        public Pedido()
        {
            productos = new List<Producto>();
        }

        public Pedido(Cliente cliente, List<Producto> productos)
        {
            this.Cliente = cliente;
            this.Productos = productos;
            this.delivery = false;
            SetOrden();
            SetVentaNum();
        }

        public Pedido(List<Producto> productos, Cliente cliente) : this(cliente, productos)
        {
            this.delivery = true;
        }

        public virtual string FormatearTexto()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto item in productos)
            {
                sb.AppendLine(item.FormatearTexto());
            }

            return sb.ToString();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------------------------------");
            sb.AppendLine("------------ Cliente -----------------");
            sb.AppendLine($"{cliente.ToString(),20}        ");
            sb.AppendLine("--------------------------------------");
            sb.AppendLine(this.FormatearTexto());


            return sb.ToString();
        }

        private void SetVentaNum()
        {
            id = Comercio.ventas.Count > 0 ? Comercio.ventas[Comercio.ventas.Count - 1].Id + 1 : 1;
        }
        private void SetOrden()
        {
            orden = cliente.Nombre.Substring(0, 1) + cliente.Apellido.Substring(0, 1) + cliente.Dni.ToString().Substring(0, 2);
        }

        public static Pedido GetPedido(int id, List<Pedido> pedidos)
        {
            foreach (Pedido p in pedidos)
            {
                if (p.id == id)
                {
                    return p;
                }
            }

            throw new Exception("Objeto No encontrado");
        }

        

    }
}
