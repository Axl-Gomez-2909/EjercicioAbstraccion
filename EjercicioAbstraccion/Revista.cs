using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Revista : Producto
    {
        //Declaración de variables 
        public string? Issn;
        public double Precio_unitario;
        public double Precio_venta;
        public int stock;
        public Revista(string titulo, string autor, string tipo, string editorial)
            : base(titulo, autor, tipo, editorial)
        {

        }
        //Uso de los metodos abstractos
        public override string imprimirDatos()
        {
            return $@"-Titulo: " + nombreProducto + "  -Autor: " + nombreAutor + "  -Tipo: " + Tipo + " -Editorial: " + editorial;
        }

        public override string imprimirCampos()
        {
            return "-ISSN :" + Issn + "  -Precio:" + Precio_unitario + " -Precio de Venta:" + Precio_venta + " -Cantidad en stock:" + stock;
        }
        public override string titulo()
        {
            return "------------------------------------------Revista------------------------------------------";
        }
    }
}
