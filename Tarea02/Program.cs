using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea02.Capitulo05;
using Tarea02.Capitulo06;
using Tarea02.Capitulo07;
using Tarea02.Capitulo08;

namespace Tarea02
{
    class Program
    {
        static void Main()
        {
                int opcion = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("01. Capitulo 5 - Ejercicio 04 (FORMULARIO) ");
                    Console.WriteLine("02. Capitulo 6 - Ejercicio 05");
                    Console.WriteLine();
                    Console.WriteLine("===================================================");
                    Console.WriteLine();
                    Console.WriteLine("03. Capitulo 6 - Ejercicio 01");
                    Console.WriteLine("04. Capitulo 6 - Ejercicio 02");
                    Console.WriteLine("05. Capitulo 6 - Ejercicio 03");
                    Console.WriteLine("06. Capitulo 6 - Ejercicio 04");
                    Console.WriteLine("07. Capitulo 6 - Ejercicio 05");
                    Console.WriteLine();
                    Console.WriteLine("===================================================");
                    Console.WriteLine();
                    Console.WriteLine("08. Capitulo 7 - Ejercicio 01");
                    Console.WriteLine("09. Capitulo 7 - Ejercicio 02");
                    Console.WriteLine("10. Capitulo 7 - Ejercicio 05");
                    Console.WriteLine();
                    Console.WriteLine("===================================================");
                    Console.WriteLine();
                    Console.WriteLine("11. Capitulo 8 - Ejercicio 03");
                    Console.WriteLine("12. Capitulo 8 - Ejercicio 05");
                    Console.WriteLine();
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            //Formulario Factorial...
                            //Lo deje de ese forma aunque hice los demas ejercicios para introducir por consola.
                            break;
                        case 2:
                        Ejercicio_5.Ejercicio05(3);
                        Console.ReadKey();
                        break;
                        case 3:
                        Ejercicios_1_2_3_4_y_5.Ejercicio01();
                            Console.ReadKey();
                            break;
                        case 4:
                        Ejercicios_1_2_3_4_y_5.Ejercicio02();
                            Console.ReadKey();
                            break;
                        case 5:
                        Ejercicios_1_2_3_4_y_5.Ejercicio03();
                            Console.ReadKey();
                            break;
                        case 6:
                        Ejercicios_1_2_3_4_y_5.Ejercicio04();
                            Console.ReadKey();
                            break;
                        case 7:
                        Ejercicios_1_2_3_4_y_5.Ejercicio05(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
                            Console.ReadKey();
                            break;
                        case 8:
                        Ejercicios_1_2_y_5.Ejercicio01();
                            Console.ReadKey();
                            break;
                        case 9:
                        Ejercicios_1_2_y_5.Ejercicio02();
                            Console.ReadKey();
                            break;
                        case 10:
                        Ejercicios_1_2_y_5.Ejercicio05();
                            Console.ReadKey();
                            break;
                        case 11:
                        Ejercicios_3_y_5.Ejercicio03();
                            Console.ReadKey();
                            break;
                        case 12:
                        Ejercicios_3_y_5.Ejercicio05();
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("Opcion Incorrecta!");
                            Console.Read();
                            Console.Clear();
                            break;
                    }
                } while (opcion != 13);
            
         /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());*/
        }
    }
}
