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
            Console.WriteLine("Ingrese el número de personas:");
            int numeroPersonas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numeroPersonas; i++)
            {
                Persona persona = new Persona();

                Console.WriteLine("Ingrese el nombre de la persona:");
                //persona.Nombre = Console.ReadLine();
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el género de la persona:");
                //persona.Genero = Console.ReadLine();
                string genero = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de persona (Estudiante o Profesor):");
                //persona.TipoPersona = Console.ReadLine();
                string tipoPersona = Console.ReadLine();

                //personas.Add(persona);

                if (tipoPersona == "Estudiante")
                {
                    Estudiante estudiante = new Estudiante();
                    estudiante.Nombre = nombre;
                    estudiante.Genero = genero;
                    estudiante.TipoPersona = tipoPersona;
                    personas.Add(estudiante);
                }
                else if (tipoPersona == "Profesor")
                {
                    Profesor profesor = new Profesor();
                    profesor.Nombre = nombre;
                    profesor.Genero = genero;
                    profesor.TipoPersona = tipoPersona;
                    personas.Add(profesor);
                }
                else
                {
                    Console.WriteLine("Tipo de persona inválido. Ingrese 'Estudiante' o 'Profesor'.");
                    i--;
                }

            }

            // Llamar a los métodos correspondientes de cada persona

            foreach (Persona persona in personas)
            {
                //if (persona.TipoPersona == "Estudiante")
                //{
                //    Estudiante estudiante = new Estudiante();
                //    estudiante.Nombre = persona.Nombre;
                //    estudiante.Genero = persona.Genero;
                //    estudiante.TipoPersona = persona.TipoPersona;
                //    estudiante.Estudiar();
                //}
                //else if (persona.TipoPersona == "Profesor")
                //{
                //    Profesor profesor = new Profesor();
                //    profesor.Nombre = persona.Nombre;
                //    profesor.Genero = persona.Genero;
                //    profesor.TipoPersona = persona.TipoPersona;
                //    profesor.Explicar();
                //}
                //else
                //{
                //    Console.WriteLine("Tipo de persona inválido. Ingrese 'Estudiante' o 'Profesor'.");
                //    //i--;
                //}
                if (persona.TipoPersona == "Estudiante")
                {
                    Estudiante estudiante = (Estudiante)persona;
                    estudiante.Estudiar();
                }
                else if (persona.TipoPersona == "Profesor")
                {
                    Profesor profesor = (Profesor)persona;
                    profesor.Explicar();
                }
            }
        }
    }
}
