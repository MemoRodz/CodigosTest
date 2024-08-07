﻿

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Animal.
    /// </summary>
    internal abstract class Animal
    {
        private string? Nombre { get; set; }

        public void AsignarNombre(string? nombre)
        {
            Nombre = nombre;
        }

        public string? ObtenerNombre()
        {
            return Nombre;
        }

        public abstract void Comer(string? nombre);
    }
}
