# Ejercicios propuestos: Introducción a POO (2)

## Ejercicio 1
<strong>Multiple-choice</strong><br>
Indique en cada punto cuáles de las afirmaciones son correctas:

La abstracción es:
	- Pensar en la implementación más que en lo general
	- Algo que usamos las personas diariamente, siempre al mismo nivel
	- La capacidad de concentrarme en los detalles importantes de algo y olvidarme de lo que no es relevante
	- Ninguna de las anteriores
	- Todas las anteriores

Para todo objeto:
	- Su comportamiento indica lo que sabe hacer
	- Su comportamiento se define mediante un conjunto de mensajes llamado protocolo
	- Su identidad permite diferenciarlo de cualquier otro
	- Siempre es instancia de una clase
	- Todas las anteriores
	- Ninguna de las anteriores

La implementación de un objeto:
	- Es privada
	- Es pública
	- Tiene acceso al estado interno del objeto
	- Todas las anteriores
	- Ninguna de las anteriores

Un mensaje que se envía a un objeto:
	- Se especifica mediante un nombre y un conjunto de parámetros
	- Siempre devuelven un resultado
	- No requiere que el objeto emisor y receptor se conozcan
	- La respuesta es siempre un objeto
	- Todas las anteriores
	- Ninguna de las anteriores
	
El encapsulamiento:
	- Protege el estado interno.
	- Simplifica la modularidad y reutilización del código
	- Nos lleva a programar pensando en la implementación más que en las propiedades de los objetos
	- Es la cualidad de los objetos de ocultar los detalles de implementación y su estado interno del mundo exterior.
	- Todas las anteriores
	- Ninguna de las anteriores
	
Una clase tiene la función de:
	- Crear instancias de la misma
	- Finalizar la ejecución y retornar un valor
	- Agrupar el comportamiento común de las instancias
	- Definir la forma de sus instancias
	- Todas las anteriores
	- Ninguna de las anteriores
La herencia:
	- Permite reutilizar código
	- Denomina clase base a la especialización de una clase derivada
	- No permite crear instancias de la clase base
	- Todas las anteriores
	- Ninguna de las anteriores
	
## Ejercicio 2
Definir la clase Cafetera, que tiene las propiedades:
	GramosAzucar
	GramosCafe
	GramosChocolate
	LitrosLeche
	CantidadVasos
	LuzAlerta

y los siguientes métodos:
	PrepararCortado
	PrepararLágrima
	PrepararCapuccino
	PrepararExpresso
	NotificarFaltante

<div style="color:red">Actualización: 7/9</div>
## Ejercicio 3.
Cree las clases y métodos que surgen de los ejercicios del tema 8. <a target="_blank" href="https://github.com/maxilovera/net-basics/blob/master/8-%20Introducci%C3%B3n%20a%20POO/Ejercicios%20propuestos.md">Acceder</a>
	
## Ejercicio Integrador (importante realizarlo en su totalidad)

Dada la necesidad de informatizar la administración del ZOO de una importante ciudad, se necesita modelar las clases necesarias para contemplar el manejo de aves, mamíferos y reptiles. 

Es de vital importancia poder almacenar el nombre de cada especie, el peso, la zona en la que se encuentra (los valores posibles son Zona1, Zona2 o Zona3) y la edad actual. 

Los distintos grupos de animales tienen otras características específicas.
	- De las aves se necesita poder conocer en un determinado momento si están en época de reproducción o no: Esto se calcula teniendo en cuenta que la fecha actual esté comprendida dentro de la PRIMAVERA.
	- De los reptiles se debe conocer si están en un reservorio con agua o no.
	- De los mamíferos se necesita conocer la cantidad de animales del clan, y la cantidad de parientes directos (padres, hermanos, o hijos).
	
Las especies de todos los grupos deben poder ser movidas de una zona a otra en cualquier momento, sin embargo para el caso de los mamíferos solo será factible si tienen más de un año y para el caso de las aves, solamente se podrán mover si no están en época de reproducción.

Llegada la fecha de cumpleaños, cada especie deberá poder aumentar su edad.