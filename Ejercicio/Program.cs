using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, nombre_consola, email;
            int contraseña, confirmacion_contraseña, num1;



            Console.WriteLine("Introduce tu nombre de usuario por favor");
            nombre = Console.ReadLine();

            Console.WriteLine("Crea una contraseña por favor");
            contraseña = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("introduce tu email por favor");
            email = Console.ReadLine();



            Console.Clear();


            Console.WriteLine("Edita el titulo de la consola");
            nombre_consola = Console.ReadLine();
            Console.Title = nombre_consola;

            Console.WriteLine("por favor confirma tu contraseña");
            confirmacion_contraseña = Convert.ToInt32(Console.ReadLine());
            Console.Clear();



            if (contraseña == confirmacion_contraseña) 
            {
              Console.WriteLine("Selecciona el color de tu consola");
                Console.WriteLine("1 color verde   2 color amarillo  3 color blanco");
                num1 = Convert.ToInt16(Console.ReadLine());


                switch (num1)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;

                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.White;


                        break;

                        default:
                        Console.WriteLine("el numero seleccionado no existe");
                        break;                

                }
                Console.Clear();
                Console.WriteLine("Nombre de usuario {0} ", nombre);
                Console.WriteLine("Email del usuario{0}", email);
            }
            else
            {
                Console.WriteLine("lo sentimos las contraseñas no coinciden :(");
            }
            Console.ReadKey();
        }
    }
}
