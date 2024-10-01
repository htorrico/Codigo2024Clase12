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
        private List<ICliente> clientes = new List<ICliente>();


        //Pasas una interfaz como parámetro: INYECTAR LA INTERFAZ!
        public void AgregarEmpleado(IPagable empleado)
        {
            empleados.Add(empleado);
        }    

        public void AgregarCliente(ICliente cliente)
        {
            clientes.Add(cliente);
        }

        public decimal CalcularDeudaTotalClientes()
        {
            decimal totalDeuda = 0;
            foreach (var item in clientes)
            {
                totalDeuda = totalDeuda + item.CalcularDeuda();
            }
            return totalDeuda;

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
