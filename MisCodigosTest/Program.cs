using System;
using MisCodigosTest.CodigoTest;
using MisCodigosTest.Clases;


Console.WriteLine("Elige la opción ('T' o 't' para terminar):");

Console.WriteLine(@"
    A) Ejercicio 'Clase Animal'.
    F) Número Fibonacci.
    N) Números primos en un rango.
    O) Ordenar palabras.
    P) Ejercico 'Clase Persona'.
    S) Sumar los dígitos del número entero.
");
string? opcion = Console.ReadLine();
if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
    opcion = "t";

while (opcion.ToLower() != "t")
{
    switch (opcion.ToLower())
    {
        case "a":
            //Ejercicio Animal
            EjercicioAnimal.Animales();
            break;
        case "f":
            //Número Fibonacci
            Fibonacci.numFib();
            break;
        case "n":
            //Obtiene todos los números primos en un rango dado.
            Primos.primosRango();
            break;
        case "o":
            //Ordenar Palabras de una Frase
            PalabrasFraseOrdenar.palabrasOrdenar();
            break;
        case "p":
            //Ejercicio Persona
            EjercicioPersona.Personas();
            break;
        case "s":
            //Sumar Digitos de un número entero
            SumaDigitosNumero.numeros();
            break;
        case "t":
            Console.WriteLine($"Elegiste {opcion}.\nHasta pronto.");
            break;
        default:
            Console.WriteLine($"Debes elegir una opción válida.");
            break;
    }
}

Console.ReadLine();










