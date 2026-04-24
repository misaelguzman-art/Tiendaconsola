Inventario inventario = new Inventario(100);
Carrito carrito = new Carrito();



Producto leche = new Producto(1, "Leche", 1.50m, 50);
Producto pan = new Producto(2, "Pan", 0.80m, 100);
Producto huevos = new Producto(3, "Huevos", 2.00m, 30);
inventario.AgregarProducto(leche);
inventario.AgregarProducto(pan);
inventario.AgregarProducto(huevos);

inventario.MostrarInventario();

carrito.AgregarProductocarrito(leche);
carrito.AgregarProductocarrito(pan);
carrito.MostrarCarrito();

