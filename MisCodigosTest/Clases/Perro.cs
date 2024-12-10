

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Perro del tipo Animal.
    /// </summary>
    internal class Perro : Animal
    {
        public override void Comer(string? nombre)
        {
            Console.WriteLine($"El perro {nombre} está comiendo sus croquetas.");
        }
    }
}
