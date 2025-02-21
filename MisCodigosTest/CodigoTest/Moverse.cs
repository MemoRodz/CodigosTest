using System.Diagnostics;
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
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; // Presión sobre botón derecho
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; // Liberación sobre botón derecho

        // Importar la función SetForegroundWindow de la API de Windows
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }

        /// <summary>
        /// Se utiliza para indicar si se ha solicitado detener el proceso.
        /// </summary>
        private static bool stopRequested = false;

        /// <summary>
        /// Lee las teclas presionadas y establece stopRequested en true si se presiona la tecla "X".
        /// </summary>
        public static void ReadInput()
        {
            while (!stopRequested)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.X)
                {
                    stopRequested = true;
                }
            }
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

        public static void Movimiento(int limiteHr)
        {
            Console.WriteLine("Cambiando tareas de usuario y moviendose...");

            // Hora límite para realizar la actividad.
            int endHr = limiteHr;
            int cambioProc = 2;
            // Minutos
            Console.WriteLine($"Moviendose poco a poco hasta las {endHr}:00 hrs.\n");
            //Establecer el área máxima de movimiento
            int screenWidth = 400;
            int screenHeight = 400;

            Random random = new();

            DateTime endTime = DateTime.Today.AddHours(endHr);
            //Establecer el tiempo de cambio de aplicación
            DateTime nextProcSwitchTime = DateTime.Now.AddMinutes(cambioProc);

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
                    Console.WriteLine($"Posición esperada ({x}, {y}).");
                    Console.WriteLine($"¿Algo pasó? a las {DateTime.Now}");
                    ProcessGet();
                }

                //Es momento de cambiar de aplicación
                if (DateTime.Now >= nextProcSwitchTime)
                {
                    ProcessGet();
                    //Reinicio de temporizador para cambio de aplicación
                    nextProcSwitchTime = DateTime.Now.AddMinutes(cambioProc);
                }
                Thread.Sleep(60000);
            }
        }

        private static void ProcessGet()
        {
            // Obtener todos los procesos en ejecución
            Process[] processes = Process.GetProcesses();

            // Filtrar los procesos para obtener solo las aplicaciones de usuario
            List<Process> userProcesses = processes.Where(p => !string.IsNullOrEmpty(p.MainWindowTitle)).ToList();

            // Mostrar la lista de aplicaciones de usuario
            Console.WriteLine("Aplicaciones abiertas:");
            //Logger.Info("\n\t<Moverse> Listado de aplicaciones abiertas:");

            foreach (Process process in userProcesses)
            {
                Console.WriteLine($"ID: {process.Id}\tTitulo: {process.MainWindowTitle}");
                //Logger.Info($"\n\t<Moverse>\tID:  {process.Id}  Titulo: {process.MainWindowTitle}");
            }

            //Cambiando a primer plano de forma aleatoria

            if (userProcesses.Count > 0)
            {
                Random random = new Random();
                int randomIndex = random.Next(userProcesses.Count);
                Process randomProcess = userProcesses[randomIndex];

                //Y en primer plano está:
                IntPtr hWnd = randomProcess.MainWindowHandle;
                SetForegroundWindow(hWnd);
                Console.WriteLine($"\nLa aplicación '{randomProcess.MainWindowTitle}' ha sido traída al frente.");
                //Logger.Info($"\n\t<Moverse>\tLa aplicación '{randomProcess.MainWindowTitle}' ha sido traída al frente.");
            }
            else
            {
                Console.WriteLine("No hay aplicaciones de usuario abiertas.");
                //Logger.Info($"\n\t<Moverse> No hay aplicaciones de usuario abiertas {DateTime.Now}");
            }
        }
    }
}
