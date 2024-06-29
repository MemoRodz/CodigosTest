using System;
using MisCodigosTest.CodigoTest;
using MisCodigosTest.Clases;


Console.WriteLine("Elige la opción ('X' o 'x' para terminar):");

Console.WriteLine(@"
    A) Ejercicio 'Clase Animal'.
    C) Cifrado SHA256 de cadenas.
    F) Número Fibonacci.
    N) Números primos en un rango.
    O) Ordenar palabras.
    P) Ejercico 'Clase Persona'.
    S) Sumar los dígitos del número entero.
    T) Conversión °C / °F.
");
string? opcion = Console.ReadLine();
if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
    opcion = "x";

while (opcion.ToLower() != "x")
{
    switch (opcion.ToLower())
    {
        case "a":
            //Ejercicio Animal
            EjercicioAnimal.Animales();
            break;
        case "c":
            Cadena256.convertirCadenaSHA256();
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
            Console.WriteLine(@"
    Convertir de:
        1) Celcius a Fahrenheit.
        2) Fahrenheit a Celcius.
");
            string opt = Console.ReadLine();
            if (opt == "1" || opt == "2")
            {
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("Dame los grados Celcius.");
                        string gradosC = Console.ReadLine();
                        decimal celsius = 0.0M;
                        if(decimal.TryParse(gradosC, out celsius))
                            Console.WriteLine($"{gradosC}°C equivalen a {TempConvert.fahrenheit(celsius).ToString("0.00")}°F\n");
                        break;
                    case "2":
                        Console.WriteLine("Dame los grados Fahrenheit.");
                        string gradosF = Console.ReadLine();
                        decimal fahrenheit = 0.0M;
                        if(decimal.TryParse(gradosF, out fahrenheit))
                            Console.WriteLine($"{gradosF}°F equivalen a {TempConvert.celsiusF(fahrenheit).ToString("0.00")}°C\n");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\nMenú principal...");
            }
            else Console.WriteLine("\nOpción inválida.\n");

            break;
        case "x":
            Console.WriteLine($"Elegiste '{opcion}'.\nHasta pronto.");
            break;
        default:
            Console.WriteLine($"Debes elegir una opción válida.");
            break;
    }
    Console.WriteLine(@"
    A) Ejercicio 'Clase Animal'.
    C) Cifrado SHA256 de cadenas.
    F) Número Fibonacci.
    N) Números primos en un rango.
    O) Ordenar palabras.
    P) Ejercico 'Clase Persona'.
    S) Sumar los dígitos del número entero.
    T) Conversión °C / °F.
    X) Terminar.
");
    opcion = Console.ReadLine();
    if (string.IsNullOrEmpty(opcion) || string.IsNullOrWhiteSpace(opcion))
        opcion = "x";
}

Console.WriteLine("Adios...\nPresiona cualquier tecla.");
Console.ReadLine();










