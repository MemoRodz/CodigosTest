using System;
using System.Collections.Generic;
using MisCodigosTest.Clases;

namespace MisCodigosTest.Clases
{
    internal class Profesor: Persona
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="nombre">Cadena con nombre de la Persona.</param>
        public Profesor(string nombre) : base(nombre)
        {
        }
        /// <summary>
        /// Método Explicar.
        /// </summary>
        public void Explicar()
        {
            Console.WriteLine("Estoy explicando.");
        }
    }
}
