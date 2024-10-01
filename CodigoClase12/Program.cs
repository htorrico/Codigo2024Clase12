
using CodigoClase12;


void Ejemplo01()
{
    List<INotificacion> notificaciones = new List<INotificacion>();

    notificaciones.Add(new Email());
    notificaciones.Add(new SMS());
    notificaciones.Add(new PUSH());
    foreach (var item in notificaciones)
    {
        item.Enviar();

    }
}

void ExampleSinInterfaces()
{
    List<Producto> productos = new List<Producto>();

    //Input
    Producto producto1 = new Producto { TipoProducto = 1, Descuento = 20 };
    Producto producto2 = new Producto { TipoProducto = 2, Descuento = 30 };
    //Tiene un campo obligatorio, descuento
    Producto producto3 = new Producto { TipoProducto = 3, Descuento = 10 };

    productos.Add(producto1);
    productos.Add(producto2);
    productos.Add(producto3);


    foreach (var item in productos)
    {
        item.Enviar();
    }

}
void ExampleConInterfaces() { 

List<IPedido> pedidos = new List<IPedido>();

ProductoA productoA= new ProductoA();
ProductoB productoB = new ProductoB();
ProductoC productoC = new ProductoC { Descuento = 20 };


pedidos.Add(productoA);
pedidos.Add(productoB);
pedidos.Add(productoC);

foreach (var item in pedidos)
{
     item.Enviar();
}

}


//ExampleSinInterfaces();
ExampleConInterfaces();


Console.Read();