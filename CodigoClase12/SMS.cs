using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class SMS : INotificacion
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando SMS");
        }
    }
}
