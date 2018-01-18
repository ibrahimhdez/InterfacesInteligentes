# Uso del Juego

Para poder iniciar el juego hay que instalar el apk del mismo. Una vez iniciado, hay un menú con un botón “Start” con el que podemos empezar el nivel. Para activar el botón basta con apuntarlo, inmediatamente después aparecerán los enemigos.


# Controles:

- Unity
	- Apuntar
	- Apuntar: Alt + mouse
	- Disparar: Click primario(izquierdo) del mouse
	- Recargar: “R”
	- Agacharse - Pararse: “C”
- Android + Gamepad:
	- Apuntar: Movimiento del móvil(Giroscopio)
	- Disparar: “R1”
	- Recargar: “X”
	- Agacharse - Pararse: “B”


# Hitos Logrados

- Uso de un controlador del juego con eventos(disparo y recarga).
- Uso de la asset store.
- Creación de un escenario.
- Uso de animaciones.
- Uso de un skybox.
- Uso del sistema de partículas.
- Comportamiento de un enemigo que siempre dispara al jugador hasta que muere.
- Uso de un Gamepad.
- Uso de sonido.

# Aspecto a destacar de la aplicación

- Hay munición y vida, las cuales se pueden ver una vez se empieza el juego.
- La munición está limitada, una vez llega a 0 si se intenta disparar se producirá una
recarga automática del arma.
- No se puede disparar mientras se recarga.
- La vida se va reduciendo hasta 0. Según el estado en el que quede al final del nivel,
se obtendrá una puntuación diferente.
- La puntuación se puede ver sólo al final del nivel.
- Existen 7 zonas diferentes en el escenario.
- El jugador se mueve de una localización a otra de forma **automática** una vez se
eliminan a todos los enemigos de esa zona.
- Al agacharse se puede evitar recibir daño si el enemigo no está muy cerca.
- Los enemigos tienen una vida. Una vez se acaba su vida se mueren realizando la
animación correspondiente. Tras 10 segundos se desactivan, eliminando el cuerpo.