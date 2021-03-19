using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace G9E1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false, error = true;
            do
            {
                int min = 0, cond = 0;
                double[] Grado = new double[9];
                Random ran = new Random();
                while (error == true)
                {
                    try
                    {
                        Console.WriteLine("Para dar una mayor probabilidad de que aparezca 8.5, ingrese el valor minimo (entre 0 a 85) para el numero aleatorio...");
                        min = int.Parse(Console.ReadLine());
                        error = false;
                    }
                    catch(FormatException err)
                    {
                        error = true;
                        Console.WriteLine("\nValor ingresado no valido...PRESIONE UNA TECLA PARA CONTINUAR");
                        Console.WriteLine(err.Message);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                Console.Clear();
                for (int i = 0; i < 9; i++)
                {
                    Grado[i] = double.Parse((ran.Next(min, 86) / 10.00).ToString());
                    Console.WriteLine("Calificacion " + (i + 1) + ": " + Grado[i]);
                    if (Grado[i] == 8.5)
                    {
                        cond++;
                    }
                }
                Console.WriteLine("\nEn total, existen " + cond + " notas iguales a 8.5");
                Console.WriteLine("(de una probabilidad de 1/" + (86 - min) + " que aparezca este numero)");
                Console.WriteLine("Desea repetir el programa de nuevo (te permitiria establecer un nuevo rango de probabilidad)... Y/N");
                char key = Console.ReadKey().KeyChar;
                if (key == 'y')
                {
                    repeat = true;
                    error = true;
                }
                else if (key == 'n')
                {
                    repeat = false;
                }
                Console.Clear();
            }
            while (repeat == true);
        }
    }
}
