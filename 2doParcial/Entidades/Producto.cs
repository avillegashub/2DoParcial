using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : IFormater
    {
        int id;
        string nombre;
        float precio;
        int tPreparacion;


        public Producto()
        {

        }
        public Producto(int id, string nombre, float precio, int tPreparacion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.TPreparacion = tPreparacion;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public int TPreparacion { get => tPreparacion; set => tPreparacion = value; }

        public string FormatearTexto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.id,-6}{this.nombre,-30}{ this.precio.ToString("n2"),-15}");
           
         

            return sb.ToString();
        }
    }
}
