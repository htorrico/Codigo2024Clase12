using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class Empresa
    {
        private List<IPagable> empleados = new List<IPagable>();
        

        //Pasas una interfaz como parámetro: INYECTAR LA INTERFAZ!
        public void AgregarEmpleado(IPagable empleado)
        {
            empleados.Add(empleado);
        }    
      
        public decimal CalcularPagosEmpleados()
        {
            decimal totalPagos = 0;

            foreach (var empleado in empleados)
            {
                totalPagos = totalPagos+ empleado.CalcularPago();
            }

            return totalPagos;
        }
    }
}
