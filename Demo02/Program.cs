using Demo02;

//Empresa empresa = new Empresa { 
//    empleados= new List<IPagable>()
//};
Empresa empresa = new Empresa();



// Agregar empleados a la empresa
empresa.AgregarEmpleado(new EmpleadoTiempoCompleto { SueldoMensual = 3000 });
empresa.AgregarEmpleado(new EmpleadoPorHoras { NumeroHoras = 15, CostoPorHora = 160 }); // Tarifa por hora, horas trabajadas
empresa.AgregarEmpleado(new EmpleadoContratado { PagoPorContrato = 5000 }); // Pago por contrato

// Calcular pagos totales
decimal totalPagos = empresa.CalcularPagosEmpleados();
Console.WriteLine($"El pago total de todos los empleados es: {totalPagos:C}");