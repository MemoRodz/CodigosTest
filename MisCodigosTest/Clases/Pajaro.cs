

namespace MisCodigosTest.Clases
{
    /// <summary>
    /// Clase Pajaro del tipo Animal.
    /// </summary>
    internal class Pajaro : Animal
    {
        public override void Comer(string? nombre)
        {
            Console.WriteLine($"El pájaro {nombre} está picoteando sus semillas.");
        }
    }
}
