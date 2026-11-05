# Jumps-dashes-and-sprints

### Acciones

Movimiento Horizontal: A, D

Movimiento Vertical: W, S

Disparo: boton izquierdo del mouse

Brincar: Espacio

Mirar: Mover Mouse

Sprint: Shift

Dodge: Double Tap Direccion


### Explicacion de Codigo:

Movimiento y vista: estos movimientos se cumplen en asignar con los teclados WASD y el Mouse las direcciones pre-asignadas con el Input proveido por el sistema. Se llaman con las funciones en PlayerMovement.cs, OnMove y OnLook, para tomar los vectores que determinaran las direcciones al pulsar los teclados. Velocidades son valores que se designan en la pantalla inspector para satisfacer velocidad deseada. 

![alt text](<Recording 2026-11-04 213014.gif>)

Disparo: Esta funcion toma un objeto, del jugador, para disparar ballas atraves de un shootingpoint, estas balas escogidas son instanciadas y luego viajaran hacia donde son apuntadas, con la funcion OnFire, llamada al usar el left mouse button.

![alt text](<Recording 2026-11-04 213930.gif>)

Brinco y doble brinco: para esta parte lo que se hizo fue setear en el InputSystem un boton para brincar. Luego de eso se utiliza la funcion OnJump para agregar impulso al rigidbody con una variable jumpPower para controlar la potencia del brinco. Para verificar la cantidad de brincos se hace variable jumps y maxJumps. maxJumps es la variable que maneja cuantos brincos puede hacer el personaje mientras que jumps verifica cuantas veces se hizo la accion. Para reiniciar la variable jumps despues de cada dos brincos se verifican las colisiones para saber si toca el suelo o no. 


<img width="1360" height="768" alt="2026-11-04 19-21-45" src="https://github.com/user-attachments/assets/613f2c7a-9e67-4406-bd47-a5eb2bf5184a" />


Sprint: Esta funcion es una modificacion del movimiento, por lo tanto es encontrado en PlayerMovement.cs tambien con Dodge. Esta es una simple multiplicacion de velocidad en pulsar el boton de shift, con la condicion de que es solo cuando se sujeta, que se toma en cuenta en el setting de inputs. Al reconocer que shift esta siendo pulsada, se duplica la velocidad, y para que no cambie la velocidad original, se usa una variable temporera para la aplicacion de velocidad.