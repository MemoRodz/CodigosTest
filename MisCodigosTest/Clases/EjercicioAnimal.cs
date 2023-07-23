

namespace MisCodigosTest.Clases
{
    public class EjercicioAnimal
    {
        public static void Animales()
        {
            Console.WriteLine("Bienvenido a la aplicación de animales.");
            Console.WriteLine("Por favor, elija el tipo de animal: \n1) Perro \n2) Gato \n3) Pájaro");
            int opcion = int.Parse(Console.ReadLine());

            Animal animal;

            switch (opcion)
            {
                case 1:
                    animal = new Perro();
                    break;
                case 2:
                    animal = new Gato();
                    break;
                case 3:
                    animal = new Pajaro();
                    break;
                default:
                    Console.WriteLine("Opción inválida. Seleccionando perro por defecto.");
                    animal = new Perro();
                    break;
            }

            Console.WriteLine("Ingrese el nombre del animal:");
            string nombre = Console.ReadLine();

            animal.AsignarNombre(nombre);

            Console.WriteLine("El nombre del animal es: " + animal.ObtenerNombre());
            animal.Comer();
        }
    }
}
