using System;
namespace intervalociclo
{
    class Program
    {
        static void Main(string[] args)
        {/*Programa que muestra una tabla de multiplicar*/
            //Entrada
            Int32  numero1;
            //Declaraciondedatos

            //Proceso


            for (int i = 1; i <= 5; i++)
            {
                for (numero1 = 1; numero1 <= 5; numero1++)
                {
                    Console.Write(i * numero1 + " ");
                    if (i * numero1 < 5) Console.Write(" ");
                }
                Console.WriteLine();
                }

                //Salida
                //Pausa
                Console.WriteLine("\n\tPresiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
