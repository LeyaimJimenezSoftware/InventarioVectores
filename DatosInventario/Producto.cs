using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosInventario
{
    class Producto
    {
        private string _codigo, _nombre, _precio, _cantidad;

        public Producto(string codigo, string nombre, string precio, string cantidad)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

     
         public string codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;
            }
        }
        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }
        public string precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }
        public string cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }
        public override string ToString()
        {
            string listaProductos = null;
            listaProductos = "Codigo: " + _codigo +" Nombre: " + _nombre + " Precio: " + _precio + " Cantidad: " + _cantidad + "\r\n" + "\r\n";
           
            return listaProductos;
        }













    }
}
