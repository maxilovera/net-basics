Se necesita un sistema para una empresa que fabrica y vende ropa. Esta empresa requiere guardar los productos que tiene en el almacén y las ventas realizadas.

Se debe crear una clase Producto que disponga de: código del producto (El código del producto debe ser único y autoincrementable), tipo (pantalón largo, short, remera o campera, etc), precio unitario, porcentaje de descuento, cantidad en stock.
 
Por cada venta, un cliente puede llevarse más de un producto distinto pero no debe cargarse 2 veces en el mismo listado. De cada venta se necesita conocer: número de ticket (debe ser un número único y autoincrementable), fecha de la compra, un listado con los códigos de productos vendidos y el monto total de la compra. El monto total debe ser una propiedad privada y debe tener un método de obtención de monto total que permita conocer su valor. 

La forma en la que se carga una venta es producto por producto, por lo tanto se debe crear un método AgregarProducto que recibirá el código de producto y la cantidad a agregar. Se deben realizar las siguientes validaciones:<br><br>

- El código de producto no debe estar agregado a la misma venta.
- Si el código de producto puede utilizarse se debe verificar que tenga el stock disponible para la cantidad de productos ingresada.
- Si el stock disponible es mayor a la cantidad ingresada, verificar si el producto tiene descuento, aplicar el mismo al precio unitario y obtener el precio final (teniendo en cuenta la cantidad ingresada).
- Luego de calcular el precio final de ese producto, sumarlo al monto final de venta. Guardar el codigo de producto en el listado de productos de la venta.

Se debe crear un método RegistrarVenta que agregue la venta al listado general una vez finalizada la carga de los datos de productos.
Este método deberá restar a todos los productos incluidos en la misma la cantidad comprada y luego retornar el monto final de venta.

Al final del día la empresa necesita emitir los siguientes listados:
-	Mostrar todas las compras realizadas en un día pasado como parámetro.
-	Mostrar un listado de productos cuyo stock sea menor a 10.

