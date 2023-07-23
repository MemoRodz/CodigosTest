using System;
using System.Collections.Generic;
using MisCodigosTest.Clases;

namespace MisCodigosTest.Clases
{
    internal class Estudiante: Persona
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="nombre">Cadena con nombre de la Persona.</param>
        public Estudiante(string nombre) : base(nombre)
        {
        }
        /// <summary>
        /// Método Estudiar.
        /// </summary>
        public void Estudiar()
        {
            Console.WriteLine("Estoy estudiando.");
        }
    }
}
