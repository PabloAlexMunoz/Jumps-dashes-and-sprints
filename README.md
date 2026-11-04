# Jumps-dashes-and-sprints

### Acciones

Movimiento Horizontal: A, D

Movimiento Vertical: W, S

Disparo: boton izquierdo del mouse

Brincar: Espacio

Mirar: Mover Mouse

Sprint: ---

Dodge: ---


### Explicacion de Codigo:

Brinco y doble brinco: para esta parte lo que se hizo fue setear en el InputSystem un boton para brincar. Luego de eso se utiliza la funcion OnJump para agregar impulso al rigidbody con una variable jumpPower para controlar la potencia del brinco. Para verificar la cantidad de brincos se hace variable jumps y maxJumps. maxJumps es la variable que maneja cuantos brincos puede hacer el personaje mientras que jumps verifica cuantas veces se hizo la accion. Para reiniciar la variable jumps despues de cada dos brincos se verifican las colisiones para saber si toca el suelo o no. 
