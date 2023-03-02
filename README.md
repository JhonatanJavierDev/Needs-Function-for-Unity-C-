# Needs-Function-for-Unity-C-
This is a small function for a system of needs (Hunger, Thirst) for your project in Unity


# Info 

This function will assume that you have two Slider objects in your Unity scene called "HungerSlider" and "ThirstSlider", and that these objects have Slider components associated with them. It also assumes that you have an object of type PlayerStatus in your scene with the script attached.

To use this function, simply call the "EatFood" and "DrinkWater" functions in response to player input, and call the "SetPlayerStopped" function when the player stops or starts moving. The "Update" function will automatically update the progress bars based on the specified decay rates.


# Información

Esta función supondrá que tienes dos objetos Slider en tu escena de Unity llamados "HungerSlider" y "ThirstSlider", y que estos objetos tienen componentes Slider asociados con ellos. También asume que tiene un objeto de tipo PlayerStatus en su escena con el script adjunto.

Para usar esta función, simplemente llame a las funciones "EatFood" y "DrinkWater" en respuesta a la entrada del jugador, y llame a la función "SetPlayerStopped" cuando el jugador se detenga o comience a moverse. La función "Actualizar" actualizará automáticamente las barras de progreso en función de las tasas de disminución especificadas.
