public class Carrito
{
    private Producto[] productos;
    private int cantidadproductos;
    private int capacidadMaxima=100;

    public Carrito()
    {
        productos = new Producto[capacidadMaxima];
        cantidadproductos = 0;
    }

    public void MostrarCarrito()
    {
        Console.WriteLine("\nCARRITO DE COMPRAS");
        if (cantidadproductos == 0)
        {
            Console.WriteLine("El carrito está vacío.");
        }
        else
        {
            for (int i = 0; i < cantidadproductos; i++)
            {
                productos[i].MostrarProducto();
            }
        }     
    }

    public void AgregarProductocarrito(Producto p)
    {
        if (cantidadproductos >= capacidadMaxima)
        {
            Console.WriteLine("Carrito lleno, no se puede agregar más productos.");
            return;
        }
        productos[cantidadproductos] = p;
        cantidadproductos++;
    }

}