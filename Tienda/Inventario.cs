public class Inventario
    {
        private Producto[] productos;
        private int cantidad;          
        private int capacidadMaxima;    

        public Inventario(int capacidad = 100)
        {
            capacidadMaxima = capacidad;
            productos = new Producto[capacidadMaxima];
            cantidad = 0;
        }

        public void AgregarProducto(Producto p)
        {
            if (cantidad >= capacidadMaxima)
            {
                Console.WriteLine("Inventario lleno, no se puede agregar más productos.");
                return;
            }
            productos[cantidad] = p;
            cantidad++;
        }
 
        public void MostrarInventario()
        {
            if (cantidad == 0)
            {
                Console.WriteLine("El inventario está vacío.");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    productos[i].MostrarProducto();
                }
            }
        
        }


    }