using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class PUSH : INotificacion
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando PUSH");
        }
    }
}
