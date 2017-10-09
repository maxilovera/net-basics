La empresa “Omar Repuestos” necesita administrar los productos que tiene en reparación, los cuales cuentan con un Nombre de producto, Nombre de Cliente, Fecha de ingreso a reparación, Fecha de compra, años de garantía.

Existen distintos tipos de productos:
- Celulares: Se debe conocer marca, modelo, pulgadas de pantalla.
- Televisores: Se debe conocer si es smart o no, cantidad de entradas HDMI.
- Lavarropas: Kg de peso, si es carga frontal o no.

De cada producto, se necesita conocer si está en garantía o no. El cálculo de la garantía es el siguiente:
- Está en garantía = (Fecha Actual - Fecha de compra) > Años garantía.

Por cada tipo de producto se requiere obtener un texto que identifique sus propiedades más importantes:
- Celular: “Marca: Modelo: ”
- Tele: “Cliente: Smart:”
- Lavarropas: “Cliente: Kg de peso:”

Se debe guardar en tres listas por separado, todos los productos reparados de cada tipo de producto y por cada producto, todos los repuestos utilizados. 
Cada producto tiene una lista de repuestos, los cuales tienen los siguientes datos: Nombre, Costo. La suma de los costos de todos los repuestos corresponden con el costo total de reparación del producto.

Obtener:
- Producto más costoso (producto cuya suma de costos de sus repuestos es mayor)
- Lista de reparaciones realizadas en el mes actual (del corriente año) para un determinado tipo de producto, mostrando:
  - Nombre del producto, Cantidad de repuestos usados, Costo total de reparación.
