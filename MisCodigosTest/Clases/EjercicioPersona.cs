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
            string nombre = Console.ReadLine();

            while(nombre != "fin")
            {
                Console.WriteLine("¿Es estudiante o profesor? (e/p)");
                string tipo = Console.ReadLine();

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
                    estudiante.Estudiar();
                }
                else if (persona is Profesor)
                {
                    Profesor profesor = (Profesor)persona;
                    profesor.Explicar();
                }

                Console.WriteLine();
            }
        }
    }
}
