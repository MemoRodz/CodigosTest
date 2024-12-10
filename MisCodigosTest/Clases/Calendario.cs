using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisCodigosTest.Clases
{
    public class Calendario
    {
        public static void Imprime()
        {
            char[] mes_nom = { 'V', 'E', 'F', 'M', 'A', 'M', 'J', 'J', 'A', 'S', 'O', 'N', 'D' };
            int[] mes_dur = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int renglon, columna, i, j, k, hoja = 0, digito, inicio, termino, bis, dia = 0, mes = 0;
            long dias = 0, year = 0;

            Console.Clear();
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("CALENDARIO");
            Console.SetCursorPosition(15, 4);
            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(15, 6);
            Console.Write("Año: ");
            year = long.Parse(Console.ReadLine());

            if (year < 1) { year = 1; }

            bis = (int)year % 4;
            dias = (year - 1) * 365 + (year - 1) / 4;

            for (i = 1; i < mes; i++) 
            { 
                if (i == 2 && bis == 0) 
                { 
                    dias += mes_dur[i] + 1; 
                } 
                else 
                { 
                    dias += mes_dur[i];
                }
            }

            dia = (int)dias % 7;
            inicio = (mes > 0 && mes < 13) ? mes : 1;
            termino = (mes > 0 && mes < 13) ? mes + 1 : 13;

            Console.Clear();

            for(i = inicio; i < termino; i++)
            {
                digito = 1;
                renglon = 3;
                Console.SetCursorPosition(30, 1 + hoja * 8);
                Console.WriteLine($"{mes_nom[i]}\tAÑO {year}");
                Console.SetCursorPosition(21, 2 + hoja * 8);
                Console.WriteLine("Dom   Lun   Mar   Mie   Jue   Vie   Sab");
                for(j = 1; j <= mes_dur[i]; j++)
                {
                    columna = dia * 6;
                    Console.SetCursorPosition(21 + columna + digito, hoja * 8 + renglon);
                    Console.Write(j);

                    dia++;
                    if (j == 9) 
                    { 
                        digito = 0; 
                    }

                    if (dia == 7) 
                    { 
                        dia = 0; 
                        renglon++; 
                    }

                    if(mes_dur[i] == 28 && j == 28 && bis == 0)
                    {
                        Console.SetCursorPosition(21 + dia * 6 + digito, hoja * 8 + renglon);
                        Console.Write(j + 1);
                        dia++;
                        if (dia == 7)
                        { 
                            dia = 0; 
                            renglon++; 
                        }
                    }
                }

                hoja++;
                if(hoja == 3)
                {
                    hoja = 0;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
