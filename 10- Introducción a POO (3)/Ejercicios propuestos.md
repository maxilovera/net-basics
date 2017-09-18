# Ejercicios propuestos: Introducción a POO (3)

NOTA: Para todos los ejercicios, crear un proyecto de biblioteca de clases para separar la lógica de resolución del problema, con la interfaz de usuario.

## Ejercicio 0 (?)
Este ejercicio se debe resolver en su totalidad, ya que se tomará de base para el módulo siguiente de la materia.

CALCULADORA:
Se necesita crear una calculadora que permita realizar las siguientes operaciones:
1) Suma
2) Resta
3) Multiplicacion
4) División: Debe validar que el 2do número no sea 0.
5) 1/x: Recibe un solo número y realiza la fracción de 1/sobre dicho número.
6) Potencia 2: Recibe un solo número y  realiza la potencia(2) del mismo. Usar la clase Math.
7) Raiz cuadrada: Recibe un solo número y realiza la raiz cuadrada del mismo. Usar la clase Math.

El valor de la operación debe guardarse en una propiedad privada del objeto, ya que se necesita mostrar, o borrar en algun momento determinado.
Debe tener un método público que devuelva el resultado actual. 

NOTA: Cada método de operación debe retornar un valor BOOLEANO que indique si la operación se realizó correctamente o no, y en caso de que sea falso debe tener tambien un mensaje de error personalizado (por ejemplo: No se puede dividir x cero)

El objeto debe tener una lista de acciones realizadas, donde se guardará el nombre de la función ejecutada junto con la hora de ejecución.
Para agregar elementos al listado, se debe crear un método privado. Con el objetivo de que solo el objeto sea responsable de cargar la lista, y no pueda hacerse desde afuera.


## Ejercicio 1
Crear una clase llamada Cuenta que tendrá los siguientes atributos: Titular y Cantidad (puede tener decimales).
El titular será obligatorio y la cantidad es opcional. Crea dos constructores que cumplan lo anterior.

Tendrá dos métodos:
<ul>
<li><strong>Ingresar(double cantidad):</strong> se ingresa una cantidad a la cuenta, si la cantidad introducida es negativa, no se hará nada.</li>
<li><strong>Retirar(double cantidad):</strong> se retira una cantidad a la cuenta, si restando la cantidad actual a la que nos pasan es negativa, la cantidad de la cuenta pasa a ser 0.</li>
</ul>

## Ejercicio 2
Crear una clase llamada Persona que siga las siguientes condiciones:

Sus atributos son: nombre, edad, DNI, sexo (H hombre, M mujer), peso y altura. No queremos que se accedan directamente a ellos. Piensa que modificador de acceso es el más adecuado, también su tipo.

Se implantaran varios constructores:
Un constructor por defecto.
Un constructor con el nombre, edad y sexo, el resto por defecto.
Un constructor con todos los atributos como parámetro.

Los métodos que se implementaran son:
<ul>
<li>calcularIMC(): calculará si la persona esta en su peso ideal (peso en kg / (altura ^ 2  en metros)), si esta fórmula devuelve un valor menor que 20, la función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos), significa que esta por debajo de su peso ideal la función devuelve un 0  y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la función devuelve un 1. <em>Usar constantes para devolver estos valores.</em></li>
<li>esMayorDeEdad(): indica si es mayor de edad, devuelve un booleano.</li>
<li>comprobarSexo(char sexo): comprueba que el sexo introducido es correcto. Devuelve un valor booleano.
<li>generaDNI(): genera un número entero aleatorio de 8 cifras. Este método sera invocado cuando se construya el objeto. Puedes dividir el método para que te sea más fácil. No será visible al exterior.</li>
</ul>

Ahora, crea un programa de consola que haga lo siguiente:

1) Pide por teclado el nombre, la edad, sexo, peso y altura.
2) Crea 3 objetos de la clase anterior, el primer objeto obtendrá las anteriores variables pedidas por teclado, el segundo objeto obtendrá todos los anteriores menos el peso y la altura y el último solo los valores iniciales.
3) Para cada objeto, deberá comprobar si esta en su peso ideal, tiene sobrepeso o por debajo de su peso ideal con un mensaje.
4) Indicar para cada objeto si es mayor de edad.

## Ejercicio 3
Haz una clase llamada Password que siga las siguientes condiciones:

Que tenga los atributos longitud y contraseña . Por defecto, la longitud sera un valor 8.

Los constructores serán los siguiente:
Un constructor por defecto.
Un constructor con la longitud que nosotros le pasemos. Modificará el atributo longitud y generará una nueva contraseña aleatoria con esa longitud.

Los métodos que implementa serán:
esFuerte(): devuelve un booleano si es fuerte o no, para que sea fuerte debe tener mas de 2 mayúsculas, mas de 1 minúscula y mas de 5 números.
generarPassword():  genera una nueva contraseña del objeto con la longitud que tenga.

Ahora, crea una aplicación de consola:

Declara una lista de objetos Passwords.
Indica por teclado la longitud de las claves.
Indica también por teclado la cantidad de objetos a generar.

Utiliza un ciclo que instancie tantos objetos como cantidad haya ingresado el usuario. 
Luego de instanciar el objeto, asigna el valor a la propiedad longitud (primer valor pasado pedido al usuario) y ejecuta el método generarPassword(). Agregar el objeto a la lista declarada inicialmente.

Al finalizar la carga, recorre la lista e imprime las contraseñas generadas y si son fuertes o no:

## Ejercicio 4
Crear una clase Libro que contenga los siguientes atributos:

	– ISBN
	– Titulo
	– Autor
	- Año
	- Editorial
	– Número de páginas

Todos los atributos deben ser privados.
Crear un constructor que reciba como parámetros los valores de los 6 atributos.
Crear un método obtenerDescripcion() que retorne un string formado por "ISBN - Titulo (Autor - Año - Editorial)"
Crear un método esLibroActual() que retorne un valor booleano si el año de publicacion es igual al año actual.
Cree una sobrecarga del método anterior para recibir un valor de año como parámetro.

Crear una aplicación de consola
Ingresar por teclado una cantidad de libros a cargar.
Generar un ciclo y pedir por teclado los valores de los 6 atributos.
Imprima por cada libro la descripción del mismo.
Imprima por cada libro si es un libro actual o no.
Imprima por cada libro si el libro tiene mas de 400 hojas.

