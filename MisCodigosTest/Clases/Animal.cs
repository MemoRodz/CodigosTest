

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Animal.
    /// </summary>
    internal abstract class Animal
    {
<<<<<<< HEAD
        private string? Nombre { get; set; }
=======
        public string? Nombre { get; set; }
>>>>>>> modificar

        public void AsignarNombre(string? nombre)
        {
            Nombre = nombre;
        }

        public string? ObtenerNombre()
        {
            if (!string.IsNullOrEmpty(Nombre))
            {
                return Nombre;
            }
            else
            {
                return string.Empty;
            }
        }

        public abstract void Comer(string? nombre);
    }
}
