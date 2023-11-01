using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
     public abstract class Producto
    {
        protected string nombreProducto;
        protected string  nombreAutor;
        protected string Tipo;
        protected string editorial;

        public Producto(string nombre, string Autor, string tipo, string Editorial)
        {
            nombreProducto = nombre;
            nombreAutor = Autor;
            Tipo = tipo;
            editorial = Editorial;
        }
        //Metodo para imprimir los datos de la clase padre
        public abstract string imprimirDatos();
        //Metodo para imprimir los datos de la clase hijas
        public abstract string imprimirCampos();
        //Metodo para imprimir tel titulo de la clase hija 
        public abstract string titulo();
    }
}
