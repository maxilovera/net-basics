Se desea desarrollar un sistema para una <strong>Concesionaria</strong>. Se deben registrar los vehículos y las ventas realizadas, para esto se solicita crear una aplicación para cumplir lo que se detalla a continuación.

Los vehículos se clasifican en: <strong>autos, camionetas y motocicletas.</strong><br>
Todos los vehículos tienen un código (string), una marca (string), un modelo (año de fabricación), un precio (double), una patente (string) y un kilometraje (double). <br>
<br>Además, dependiendo del tipo se debe guardar ciertas características:
<div style="padding-left:30px">
a. Cuando se trata de una moto, estas también tienen una cilindrada en particular en cc (110, 125, etc) y si está incluido el casco en el precio de venta o no. En caso que el casco no esté incluido en el precio su valor también deberá ser definido.<br>
b. Cuando se registra una camioneta se debe saber si la misma posee lona cubre carga o no.<br>
c. Las motos y camionetas son siempre 0km, los autos pueden ser 0km o usados.
</div>
<br>
La concesionaria lleva un registro de las ventas realizadas, 
cada registro se compone por la siguiente información: 
<div style="padding-left:30px">
1. número de venta (debe ser único e incrementarse automáticamente para cada registro de venta), <br>
2. fecha de la venta, <br>
3. monto de la venta, <br>
4. tipo de vehículo (enumerador de auto, moto o camioneta)<br>
4. Vehículo vendido, (objeto completo)<br>
5. apellido, nombre y dni del comprador.
</div>
<br>Se debe crear un método que permita registrar una nueva venta, la cual será guardada en un listado. Dicho método deberá recibir solo 2 parámetros (Código de vehículo y Datos del comprador).<br>
 
La concesionaria solicitó además poder contar con la siguiente información: <br>
<strong>Un listado con las ventas realizadas en el corriente mes. Donde se detalle:</strong><br>
   a) Fecha de venta<br>
   b) Monto de venta<br>
   c) Detalle de vehículo: <br>El detalle de un vehículo cambiará según el tipo de vehículo que se haya vendido.<br>
   <div style="padding-left:30px">
       i.a) Autos: Marca - Modelo Tipo (Usado - 0KM)<br>
       i.b) Motos: Marca - Modelo - Cilindrada<br>
       i.c) Camionetas: Marca - Modelo - Con/Sin lona.<br>
    </div>
    <br><em>Para facilitar la lectura del código se debe cumplir este paso usando un método con el mismo nombre. (método virtual).</em><br><br>
 
<strong>Un listado de los vehículos que aún no se han vendido.</strong><br>
<strong>Nota:</strong> Para obtener un número incremental puede usar la cantidad de elementos de la lista de ventas realizada + 1.
