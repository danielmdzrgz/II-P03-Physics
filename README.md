# II-P03-Physics

Para esta práctica hemos trabajado con diferentes aspectos de las físicas de Unity, la utilización de clases provenientes de la API de Unity como Input y las físicas (Collider, OnCollisionEnter, OnTriggerEnter...), etc.

A continuación se mostrará el resultado de cada ejercicio con un GIF.

## Ejercicio 1
![Ejecución ejercicio1](./exercise1.gif)

## Ejercicio 2
![Ejecución ejercicio2](./exercise2.gif)

## Ejercicio 3
Resultados de las situaciones:

a. Duplicas las coordenadas de la dirección del movimiento:

El cubo se mueve en la misma dirección, pero con el doble de la velocidad en esa dirección específica.

b. Duplicas la velocidad manteniendo la dirección del movimiento:

El cubo se mueve más rápido en la misma dirección.

c. La velocidad que usas es menor que 1:

El cubo se mueve más lento en la dirección especificada. Puede parecer que el cubo se desplaza a una velocidad reducida en comparación con la velocidad normal.

d. La posición del cubo tiene y>0:

El cubo se eleva desde esa posición inicial en la dirección especificada por moveDirection.

e. Intercambiar movimiento relativo al sistema de referencia local y el mundial:

Si cambias entre el movimiento relativo al sistema de referencia local y el mundial, el cubo siempre se moverá en la misma dirección en el espacio global, independientemente de su orientación local. Esto significa que la dirección del movimiento será constante en el espacio mundial.

![Ejecución ejercicio3](./exercise3.gif)

## Ejercicio 4
![Ejecución ejercicio4](./exercise4.gif)

## Ejercicio 5
![Ejecución ejercicio5](./exercise5.gif)

## Ejercicio 6
![Ejecución ejercicio6](./exercise6.gif)

## Ejercicio 7
![Ejecución ejercicio7](./exercise7.gif)

## Ejercicio 8
![Ejecución ejercicio8](./exercise8.gif)

## Ejercicio 9
![Ejecución ejercicio8](./exercise9.gif)

## Ejercicio 10
![Ejecución ejercicio8](./exercise10.gif)

## Ejercicio 11
![Ejecución ejercicio8](./exercise11.gif)

## Ejercicio 12
Resultados de aplicar las distintas configuraciones:
- Aplicando configuraciones a la esfera:
  - Masa 10 veces mayor que el cilindro: La esfera es más difícil de mover por a su mayor masa y el cilindro necesitará ejercer una fuerza mayor para moverla.
  - Masa 10 veces menor que el cilindro: El caso contrario, el cilindro mueve muy fácilmente la esfera sin apenas necesitar fuerza.
  - Esfera cinemática: La esfera no experimenta ninguna interacción física con el cilindro, el cilindro pasa a través de la esfera sin ningún efecto.
  - Esfera trigger: Cuando el cilindro entra en la zona de trigger de la esfera, puede activar eventos o notificar la colisión, pero la esfera no ejerce fuerzas físicas sobre el cilindro ni detiene su movimiento.
 
- Aplicando configuraciones al cilindro:
  - Duplicar la fricción: Aumenta la resistencia que experimenta el cilindro cuando se desplaza sobre una superficie. Esto puede hacer que el cilindro se mueva más lentamente y requiera más fuerza para acelerar o cambiar de dirección y tener dificultades para moverse hacia la esfera y/o moverla.
  - No duplicar la fricción: El cilindro mantiene su fricción normal con la superficie en la que se encuentra permitiendo que se desplace más fácilmente que con el doble de fricción.

![Ejecución ejercicio8](./exercise12.gif)
