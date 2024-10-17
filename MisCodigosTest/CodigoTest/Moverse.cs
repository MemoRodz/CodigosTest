using System.Drawing;
using System.Runtime.InteropServices;

namespace MisCodigosTest.CodigoTest
{
    public class Moverse
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; // Presión sobre botón derecho
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; // Liberación sobre botón derecho

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int X;
            public int Y;
        }

        public static void Movimiento()
        {
            Console.WriteLine("Moviendose poco a poco...");

            int endHr = 18;

            //Establecer el área máxima de movimiento
            int screenWidth = 400;
            int screenHeight = 400;

            Random random = new();

            DateTime endTime = DateTime.Today.AddHours(endHr);

            while (DateTime.Now < endTime)
            {
                int x = random.Next(100, screenWidth);
                int y = random.Next(100, screenHeight);

                bool result = SetCursorPos(x, y);

                //Console.WriteLine(result ? $"Se movió a la posición ({x}, {y}) siendo las {DateTime.Now}." : "¿Algo pasó?");
                if (result)
                {
                    Console.WriteLine($"Se movió a la posición ({x}, {y}) siendo las {DateTime.Now}");
                    //Activar el botón Derecho
                    mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                }
                else
                {
                    Console.WriteLine("¿Algo pasó?");
                }

                System.Threading.Thread.Sleep(60000);
            }
        }
    }
}
