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
    Console.WriteLine("S. Salir.");
    Console.Write("Selecciona una opción: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            //Número Fibonacci
            Fibonacci.NumFib();
            break;
        case "2":
            //Sumar Digitos de un número entero
            SumaDigitosNumero.Numeros();
            break;
        case "3":
            //Ordenar Palabras de una Frase
            PalabrasFraseOrdenar.PalabrasOrdenar();
            break;
        case "4":
            //Obtiene todos los números primos en un rango dado.
            Primos.PrimosRango();
            break;
        case "5":
            //Ejercicio Persona
            /*
            Programa que solicita al usuario nombres de personas y los almacena en una lista de objetos de tipo Persona. Habrá dos tipos de persona: Estudiante y Profesor.

            Crear la clase Persona con una propiedad Nombre de tipo string, un constructor que reciba el nombre como parámetro, y sobreescibir el método ToString()
            imprimiendo una frase de saludo con el nombre incluido.

            Crear dos clases más que hereden de la clase Persona, se llamarán Estudiante y Profesor. La clase Estudiante tiene el método Estudiar que escribe la frase: "Estoy estudiando".
            La clase Profesor tendrá el método Explicar que debe escribir la frase: "Estoy explicando".

            El programa debe leer la lista personas (Profesores y estudiantes) ya sea en lote o uno por uno, incluirlas como profesor o estudiante, y finalmente llamar a los métodos 
            Explicar y Estudiar según el caso.
            */
            EjercicioPersona.Personas();
            break;
        case "6":
            /*
            Método que establece un área para mover aleatoriamente el puntero del mouse y hacer clic con el botón derecho.
            Esto lo hará cada minuto hasta la hora configurada.
            */
            Moverse.Movimiento();
            break;
        case "7":
            /*
             Simplemente obtiene una subcadena de la cadena establecida.
            */
            Console.WriteLine($"Subcadena obtenida: {ObtenSubCadena.Obten()}");
            break;
        case "8":
            //Ejercicio Animal
            /*
            Programa que implemente una clase abstracta Animal con una propiedad Nombre de tipo texto y tres métodos:

            -Asignar Nombre: Recibe un nombre de tipo string.
            -Obtener Nombre: Devuelve el nombre.
            -Comer: Método abstracto sin parámetros.

            Crear mínimo dos clases que implementen la clase Animal y  que sobreescriban el método Comer, este último método deberá imprimir una frase diferente para cada animal.

            El programa debe permitir al usuario asignar un nombre al animal escogido, crear un nuevo objeto de ese tipo, y usar los métodos para obtener el nombre e indicar que 
            está comiendo llamando al método respectivo.
            */
            EjercicioAnimal.Animales();
            break;
        case "s":
        case "S":
            Console.WriteLine("\nSaliendo del programa...");
            return;
        default:
            Console.WriteLine("\nOpción no válida. Inténtalo de nuevo.");
            break;
    }

    Console.WriteLine("\nPresiona cualquier tecla para continuar...");
    Console.ReadKey();
}












//Ejercicio Diagrama
/*

Implemente el siguiente diagrama de clases. El diagrama representa atributos públicos (+), privados (-), y protegidos (#) también como dependencias de clase y herencia.

Se hace la implementación del diagrama, no se pide desarrollo de métodos.

1. Se crea la clase "Forma" que actuará como clase base para las clases "Circulo" y "Rectangulo". La clase "Forma" tendrá los atributos y métodos comunes a todas las formas.
    MisCodigosTest.Clases.Diagrama.Forma    
    
2. Se crea la clase "Localizacion" que representa las coordenadas x e y de una forma. Esta clase tendrá los atributos privados "x" y "y".
    MisCodigosTest.Clases.Diagrama.Localizacion

3. Se crea la clase "Rectangulo" que hereda de la clase "Forma". Esta clase tendrá los atributos protegidos "lado1" y "lado2".


4. Se crea la clase "Circulo" que también hereda de la clase "Forma". Esta clase tendrá el atributo protegido "radio".

Con estas clases implementadas, se han creado las estructuras necesarias para representar el diagrama de clases dado. 
Ahora podemos utilizar estas clases en nuestro programa según sea necesario.

IMPORTANTE: Se debe tener en cuenta que en el diagrama se muestra que la clase "Forma" tiene un atributo protegido "loc" de tipo "Localizacion". 
Sin embargo, en el código, este atributo se declara como protegido en la clase "Forma" pero no se muestra la relación de dependencia con la clase "Localizacion". 
Por lo tanto, se asume que la clase "Forma" tiene una relación de dependencia con la clase "Localizacion" y que el atributo "loc" se utiliza para almacenar la ubicación de la forma.

*/





