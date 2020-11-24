using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Funcionalidad;

namespace TicketTracker
{
    public partial class FrmTracker : Form
    {
        public delegate void SwapGrid(object o);
        public SwapGrid GripSwap;



        List<Pedido> pedidos;
        List<Pedido> despachos;
        List<Thread> hilos;



        public FrmTracker()
        {
            InitializeComponent();
        }

        private void FrmTracker_Load(object sender, EventArgs e)
        {
                pedidos = new List<Pedido>();
                despachos = new List<Pedido>();
                hilos = new List<Thread>();
            
            try
            {
                this.GripSwap += Hold;
                
                rtMostrar.SelectionAlignment = HorizontalAlignment.Center;
                DataBase.TraerClientes();
                DataBase.TraerProductos();
                pedidos = Xml<List<Pedido>>.Leer("pedidos.xml");
                TraerPedidos();
            }
            catch (Exception ex)
            {
                string.Concat(DateTime.Now.ToString(), ex.Message).RegistrarError();
            }

        }

        // Trae Pedidos después del Load
        private void TraerPedidos()
        {
            this.GripSwap += ChangeStatus;
            foreach (Pedido item in pedidos)
            {
                Hilar(item);
            }
            DibujarOrden();
        }

        #region Genera Pedido Random
        private void btGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            try
            {
                switch (random.Next(0, 2))
                {
                    case 1:
                        GenerarPedido();
                        break;
                    default:
                        GenerarDelivery();
                        break;
                }
            }
            catch (Exception ex)
            {
                string.Concat(DateTime.Now.ToString(), ex.Message).RegistrarError();
            }
        }

        private void GenerarPedido()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            pedidos.Add(new Pedido(Comercio.clientes[random.Next(0, Comercio.clientes.Count())], ObtenerProductos()));
            rtMostrar.Text = $"{pedidos.Last<Pedido>()} \n {rtMostrar.Text}";
            DibujarOrden();
            Hilar(pedidos.Last());
        }

        private void GenerarDelivery()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            this.GripSwap += ChangeStatus;
            pedidos.Add(new Delivery(Comercio.clientes[random.Next(0, Comercio.clientes.Count())], ObtenerProductos()));
            rtMostrar.Text = pedidos.Last<Pedido>().ToString();
            DibujarOrden();
            Hilar(pedidos.Last());
        }

        //Obtien Productos Random
        private List<Producto> ObtenerProductos()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            List<Producto> productos = new List<Producto>();
            productos.Add(Comercio.productos[random.Next(0, Comercio.productos.Count())]);
            productos.Add(Comercio.productos[random.Next(0, Comercio.productos.Count())]);
            productos.Add(Comercio.productos[random.Next(0, Comercio.productos.Count())]);
            productos.Add(Comercio.productos[random.Next(0, Comercio.productos.Count())]);
            return productos;
        }


        #endregion


        //Dibuja Grids
        private void DibujarOrden()
        {
            try
            {
                dgvWait.Rows.Clear();
                foreach (Pedido item in pedidos)
                {
                    dgvWait.Rows.Add(item.Orden);
                }
                dgvReady.Rows.Clear();
                for (int i = despachos.Count; i > 0; i--)
                {
                    dgvReady.Rows.Add(despachos[i - 1].Orden, (despachos[i - 1] as Pedido).Delivery ? "DELIVERY" : "ENTREGADA");
                }
            }
            catch (Exception)
            {
                DibujarOrden();
            }
            while (RemueveThreads()) ;
        }

        //Comienza Hilo de Orden
        private void Hilar(object pedido)
        {
            hilos.Add(new Thread(new ParameterizedThreadStart(GripSwap)));
            hilos[hilos.Count - 1].Start(pedido);
        }

        //Tiempo de Espera
        private void Hold(object pedido)
        {
            this.GripSwap -= ChangeStatus;
            Comercio.IngresarVenta(pedido);
            Thread.Sleep((pedido as Pedido).Productos.Select(i => i.TPreparacion).Sum());
            despachos.Add(pedido as Pedido);
            pedidos.Remove(pedido as Pedido);

            if (this.InvokeRequired)
                this.BeginInvoke((MethodInvoker)delegate () { DibujarOrden(); });
            else
               this.DibujarOrden();
        }


        private void ChangeStatus(object p)
        {
            try
            {
                Thread.Sleep(10000);
                (p as Pedido).Delivery = false;
                if (this.InvokeRequired)
                    this.BeginInvoke((MethodInvoker)delegate () { DibujarOrden(); });
                else
                    this.DibujarOrden();
            }
            catch (Exception ex)
            {

                string.Concat(DateTime.Now.ToString(), ex.Message).PrintTicket();
            }

        }


        //Mata hilos Activos - Guarda Pedidos sin Despachar
        private void FrmTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (Thread t in hilos)
                {
                    if (t.IsAlive)
                        t.Abort();
                }
                Xml<List<Pedido>>.Guardar(pedidos, "pedidos.xml");
                Comercio.GuardaXml();
            }
            catch (Exception ex)
            {
                string.Concat(DateTime.Now.ToString(), ex.Message).PrintTicket();
            }
        }

        //Borrar luego
        private void button1_Click(object sender, EventArgs e)
        {
            int asd = 0;
            foreach (Thread t in hilos)
            {
                if (t.IsAlive)
                {
                    asd++;
                }

            }
            //boxHilos.Text = asd.ToString();
            //Comercio.GuardaXml(pedidos); 


        }

        //Remueve hilos inactivos de Lista
        private bool RemueveThreads()
        {
            foreach (Thread h in hilos)
            {
                if (!(h.IsAlive))
                {
                    hilos.Remove(h);
                    return true;
                }
            }
            return false;
        }


    }
}
