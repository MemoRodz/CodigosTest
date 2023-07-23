using System;
using System.Collections.Generic;

namespace MisCodigosTest.Clases
{
    internal class Persona
    {
        /// <summary>
        /// Nombre de la Persona.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Cadena con nombre de la Persona.</param>
        public Persona(string nombre)
        {
            Nombre = nombre;
        }
        /// <summary>
        /// Sobre escritura del método ToString
        /// </summary>
        /// <returns>Saludo incluyendo el nombre.</returns>
        public override string ToString()
        {
            return "¡Hola! Mi nombre es " + Nombre + ".\n";
        }

    }
}
