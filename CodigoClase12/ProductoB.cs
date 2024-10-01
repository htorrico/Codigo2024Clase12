using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class ProductoB : IPedido
    {
        public void Enviar()
        {
            Console.WriteLine("Enviar producto a proveedor B");
        }
    }
}
