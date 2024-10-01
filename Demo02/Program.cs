using Demo02;


Empresa empresa = new Empresa();



// Agregar empleados a la empresa
empresa.AgregarEmpleado(new EmpleadoTiempoCompleto { SueldoMensual = 3000 });
empresa.AgregarEmpleado(new EmpleadoPorHoras { NumeroHoras = 15, CostoPorHora = 160 }); // Tarifa por hora, horas trabajadas
empresa.AgregarEmpleado(new EmpleadoContratado { PagoPorContrato = 5000 }); // Pago por contrato

empresa.AgregarCliente(new ClienteVIP { CostoServicio = 4000, Descuento = 500 });
empresa.AgregarCliente(new ClienteClasico { CostoServicio = 2000 });


// Calcular pagos totales
decimal totalPagos = empresa.CalcularPagosEmpleados();
decimal totalDeudas= empresa.CalcularDeudaTotalClientes();
Console.WriteLine($"El pago total de todos los empleados es: {totalPagos:C}");
Console.WriteLine($"El total de deudas todos los clientes es: {totalDeudas:C}");