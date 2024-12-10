

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Gato del tipo Animal.
    /// </summary>
    internal class Gato : Animal
    {
        public override void Comer(string? nombre)
        {
            Console.WriteLine($"El gato {nombre} está disfrutando de su pescado.");
        }
    }
}
