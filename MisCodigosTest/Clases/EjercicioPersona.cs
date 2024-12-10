using System;
using System.Collections.Generic;
using MisCodigosTest.Clases;

namespace MisCodigosTest.Clases
{
    public class EjercicioPersona
    {
        public static void Personas()
        {
            List<Persona> personas = new List<Persona>();

            // Leer los datos de las personas y agregarlas a la lista
            Console.WriteLine("Ingrese los nombres de las personas (escriba 'fin' para terminar):");
            string? nombre = Console.ReadLine();

            while(nombre != "fin")
            {
                Console.WriteLine("¿Es estudiante o profesor? (e/p)");
                string? tipo = Console.ReadLine();


                switch (tipo)
                {
                    case "e":
                        personas.Add(new Estudiante(nombre));
                        break;
                    case "p":
                        personas.Add(new Profesor(nombre));
                        break;
                    default:
                        Console.WriteLine("No existe '{0}' como opción, {1} no se pudo clasificar.", tipo, nombre);
                        break;
                }

                Console.WriteLine("Ingrese el nombre de la persona:");
                //persona.Nombre = Console.ReadLine();
                string? nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el género de la persona:");
                //persona.Genero = Console.ReadLine();
                string? genero = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de persona (Estudiante o Profesor):");
                //persona.TipoPersona = Console.ReadLine();
                string? tipoPersona = Console.ReadLine();

                //personas.Add(persona);


                /*
                 Estructura IF ELSE
                if (tipo == "e")
                {
                    personas.Add(new Estudiante(nombre));
                }
                else if (tipo == "p")
                {
                    personas.Add(new Profesor(nombre));
                }
                else
                {
                    Console.WriteLine("No existe '{1}' como opción, {2} no se pudo clasificar.");
                }
                */

                Console.WriteLine("Nombre de la siguiente persona:");
                nombre = Console.ReadLine();
            }

            Console.WriteLine();
            // Llamar a los métodos correspondientes de cada persona

            foreach (Persona persona in personas)
            {

                Console.WriteLine(persona.ToString());

                if (persona is Estudiante)
                {
                    Estudiante estudiante = (Estudiante)persona;
                    Console.WriteLine($"{persona.Nombre} es {persona.Genero} y");
                    estudiante.Estudiar();
                }
                else if (persona is Profesor)
                {
                    Profesor profesor = (Profesor)persona;
                    Console.WriteLine($"{persona.Nombre} es {persona.Genero} y");
                    profesor.Explicar();
                }

                Console.WriteLine();
            }
            Console.WriteLine("\nMenú principal...");
        }
    }
}
