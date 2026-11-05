Jumps-dashes-and-sprints

Acciones

Movimiento horizontal: A, D

Movimiento vertical: W, S

Disparo: Botón izquierdo del mouse

Brincar: Espacio

Mirar: Mover el mouse

Sprint: Shift

Dodge: Double Tap de una dirección

Explicación de código

Movimiento y vista: Estos movimientos se implementan mediante la asignación de las teclas WASD y el mouse a las direcciones correspondientes, utilizando el sistema de Input de Unity. Se utilizan las funciones OnMove y OnLook, ubicadas en PlayerMovement.cs, para obtener los vectores que determinan las direcciones según las teclas pulsadas y el movimiento del mouse. Las velocidades son valores que se configuran desde la pantalla del Inspector para establecer la velocidad deseada. 

![alt text](<Recording 2026-11-04 213014.gif>)

Disparo: Esta función utiliza un objeto del jugador para disparar balas a través de un ShootingPoint. Las balas seleccionadas son instanciadas y luego viajan en la dirección hacia donde apunta el jugador. Esto se realiza mediante la función OnFire, que se activa al presionar el botón izquierdo del mouse.


![alt text](<Recording 2026-11-04 213930.gif>)

Brinco y doble brinco: Para esta parte, se configuró un botón en el Input System para realizar el brinco. Luego, se utiliza la función OnJump para agregar un impulso al Rigidbody, mediante una variable llamada jumpPower, que permite controlar la potencia del brinco. Para verificar la cantidad de brincos realizados, se utilizan las variables jumps y maxJumps. maxJumps determina cuántos brincos puede realizar el personaje, mientras que jumps registra cuántas veces se ha ejecutado la acción. Para reiniciar la variable jumps después de realizar los dos brincos, se verifican las colisiones para determinar si el personaje está tocando el suelo. 


<img width="1360" height="768" alt="2026-11-04 19-21-45" src="https://github.com/user-attachments/assets/613f2c7a-9e67-4406-bd47-a5eb2bf5184a" />


Sprint: Esta función es una modificación del movimiento y, por lo tanto, también se encuentra en PlayerMovement.cs, junto con la función Dodge. Consiste en multiplicar la velocidad por un valor determinado al presionar la tecla Shift. Sin embargo, la velocidad adicional solo se aplica mientras se mantiene presionada la tecla, según la configuración de los Inputs. Al detectar que Shift está siendo presionada, se multiplica la velocidad por 3. Para evitar modificar el valor de la velocidad original, se utiliza una variable temporal para aplicar el cambio.

![alt text](<Recording 2026-11-04 214701.gif>)

Dodge: Para esta función, se crearon nuevas variables que permiten guardar la dirección del movimiento anterior y determinar la dirección del Dodge. Esta acción se activa mediante una doble pulsación de los botones direccionales. Para implementarla, se utilizan OnDodge y los vectores lastdir y dodgeDirection. La dirección del Dodge se obtiene de lastdir, que guarda la última dirección registrada mediante OnMove. El movimiento se realiza multiplicando la velocidad por 10 durante un solo frame. Por esta razón, el código de movimiento se ejecuta nuevamente dentro de la condición if (isDodging).

![alt text](<Recording 2026-11-04 215901.gif>)