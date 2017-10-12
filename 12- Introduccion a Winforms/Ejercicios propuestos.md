# Ejercicios propuestos: Introducción a POO (3)

## Ejercicio 1
Cree una aplicación Winform para determinar un número Fibonacci y un número factorial.
A continuación un ejemplo de la interfaz.

### Ejemplo 1
<img src="https://github.com/maxilovera/net-basics/blob/master/12- Introduccion a Winforms/assets/Imagen1.png"/>

### Función Fibonacci.
<blockquote>
public long Fibonacci(long numero)
{
	if (numero <= 1)
	{
		return numero;
	}
	else
	{
		return Fibonacci(numero - 1) + Fibonacci(numero - 2);
	}
}
</blockquote>

### Función Factorial.

<blockquote>
public long Factorial(long numero)
{
	if (numero == 0)
	{
		return 1;
	}
	else
	{
		return Factorial(numero - 1) * numero;
	}
}
</blockquote>