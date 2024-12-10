using System;
using MisCodigosTest.CodigoTest;
using MisCodigosTest.Clases;
using MisCodigosTest.Clases.Cadena;


while (true)
{
    Console.Clear();
    Console.WriteLine("Menú de Opciones:");
    Console.WriteLine("1. Serie Fibonacci hasta un número dado.");
    Console.WriteLine("2. Sumar Digitos de un número entero.");
    Console.WriteLine("3. Ordena las Palabras de una Frase.");
    Console.WriteLine("4. Obtiene todos los números primos en un rango dado.");
    Console.WriteLine("5. Ejercicio Persona.");
    Console.WriteLine("6. Establece un área para mover el puntero aleatoriamente y hacer clic derecho.");
    Console.WriteLine("7. Obtener la subcadena establecida.");
    Console.WriteLine("8. Ejercicio Animal.");
    Console.WriteLine("9. Impresión de Calendarios.");
    Console.WriteLine("10. <Regex> Validación de RFC.");
    Console.WriteLine("S. Salir.");
    Console.Write("Selecciona una opción: ");

//Ordenar Palabras de una Frase
PalabrasFraseOrdenar.palabrasOrdenar();

//Obtiene todos los números primos en un rango dado.
Primos.primosRango();

//Ejercicio Persona
EjercicioPersona.Personas();

//Ejercicio Animal
EjercicioAnimal.Animales();

Console.ReadLine();










