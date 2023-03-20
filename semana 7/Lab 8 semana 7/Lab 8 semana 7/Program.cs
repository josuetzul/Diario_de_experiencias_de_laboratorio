using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_semana_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";
            while (!continuar.Equals("d"))
            {
                
                Console.WriteLine("Por favor ingrese una opción: \n");

                Console.WriteLine("a) sumatoria");
                Console.WriteLine("b) mostrar tablas de multiplicar");
                Console.WriteLine("c) número perfecto");
                Console.WriteLine("d) para salir del programa");

                bool valid = char.TryParse(Console.ReadLine(), out char opcion);
                if (valid)
                {
                    if (opcion == 'a' || opcion == 'b' || opcion == 'c' || opcion == 'd')
                    {
                        Console.WriteLine("\n");

                        switch (opcion)
                        {
                            case 'a':
                                Console.WriteLine("Eligió la opción Sumatoria \n");
                                Console.WriteLine("Por favor ingrese un número para sumarlo");
                                int num = Convert.ToInt32(Console.ReadLine());
                                int i = 0, suma = 0;
                                do
                                {
                                    suma = suma + i;
                                    i++;
                                }
                                while (i <= num);
                                Console.WriteLine("La suma de los números de 1 hasta " + num + " es igual a: " + suma);
                                //regreso a menú y limpieza de consola
                                Console.WriteLine("\n");
                                Console.WriteLine("Pulse Enter para regresar al menú");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 'b':
                                Console.WriteLine("Eligió la opción B \n");
                                Console.WriteLine("Por favor ingrese un número para ver su tabla de multiplicar");
                                int num_mult = Convert.ToInt32(Console.ReadLine());
                                int j = 0, mult = 0;
                                for (j = 1; j <= 10; j++)
                                {
                                    mult = num_mult * j;
                                    Console.WriteLine(num_mult + " * " + j + " = " + mult);
                                }
                                //regreso a menú y limpieza de consola
                                Console.WriteLine("\n");
                                Console.WriteLine("Pulse Enter para regresar al menú");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 'c':
                                Console.WriteLine("Eligió la opción C \n");

                                //validar que sea mayor a 0 y que no sean letras 

                                int n_perfecto = 0, suma_fact = 0;
                                Console.WriteLine("Ingrese un número para evaluar si es perfecto");

                                bool n_valido = int.TryParse(Console.ReadLine(), out n_perfecto);
                                if (n_perfecto > 0 && n_valido)
                                {

                                    int k = 2;

                                    while (k <= n_perfecto)
                                    {
                                        if (n_perfecto % k == 0)
                                        {
                                            suma_fact = suma_fact + (n_perfecto / k);
                                        }
                                        k = k + 1;
                                    }
                                    if (suma_fact == n_perfecto)
                                    {
                                        Console.WriteLine("El número que ingresó es pefecto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El nuúmero que ingresó no es perfecto");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese un número mayor a 0 y NO utilice letras");
                                }
                                //regreso a menú y limpieza de consola
                                Console.WriteLine("\n");
                                Console.WriteLine("Pulse Enter para regresar al menú");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case 'd':
                                continuar = "d";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese una opción correcta");
                        Console.WriteLine("\n");
                        Console.WriteLine("Pulse Enter para regresar al menú");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una opción correcta");
                    Console.WriteLine("\n");
                    Console.WriteLine("Pulse Enter para regresar al menú");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
