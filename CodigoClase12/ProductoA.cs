using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class ProductoA : IPedido
    {
        public void Enviar()
        {
            Console.WriteLine("Enviar producto a proveedor A");
        }
    }
}
