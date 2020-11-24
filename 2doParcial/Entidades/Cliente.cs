using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : IFormater
    {
        int id;
        string nombre;
        string apellido;
        int dni;
        string direccion;

        public Cliente()
        {

        }

        public Cliente(int id, string nombre, string apellido, int dni, string direccion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Id = id;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Id { get => id; set => id = value; }

        public string FormatearTexto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI:       {this.dni}");
            sb.AppendLine($"Nombre:    {this.Nombre}");
            sb.AppendLine($"Apellido:  {this.Apellido}");
            sb.AppendLine($"Direccion: {this.direccion}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}
