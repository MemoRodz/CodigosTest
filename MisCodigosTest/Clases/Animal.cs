

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Animal.
    /// </summary>
    internal abstract class Animal
    {
        public string? Nombre { get; set; }

        public void AsignarNombre(string? nombre)
        {
            Nombre = nombre;
        }

        public string ObtenerNombre()
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

        public abstract void Comer();
    }
}
