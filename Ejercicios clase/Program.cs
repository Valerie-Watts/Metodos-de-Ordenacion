using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Ordenación
{
    class Program
    {
        static void Main(string[] args)
        {
            Ordenación metodos = new Ordenación();
            int opt; 
             

            while (true)
            {
                int[] array = new int[] { 1, 4, 5, 7, 3, 8, 2, 9, 10, 21, 6, 11, 51, 49, 80, 100, 30, 64, 63, 2149, 552, 1864 };


                Console.WriteLine("\nEste es el arreglo a ordenar: ");
                metodos.print(array);
                Console.WriteLine("\n------------------------------------------------");
                Console.WriteLine("===Escoja el metodo para ordenar el arreglo===");
                Console.WriteLine("Ordenamiento Burbuja: \n--1.Burbuja Menor\n--2.Burbuja Mayor\n--3.Burbuja Señal");
                Console.WriteLine("4.Ordenamiento de Sacudida\nOrdenamiento de Inseción:\n--5.Inserción\n--6.Inserción Binaria");
                Console.WriteLine("7.Ordenamiento por Selección\n8.Ordenamiento por Shell\n9.Ordenamiento por Quicksort\n10.Ordenamiento por Heapsort\n11.Salir");
                Console.WriteLine("------------------------------------------------");
                Console.Write("Escriba su opción: ");
                opt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(); 
                
                switch (opt)
                {
                    case 1:
                        metodos.BurbujaMenor(array); 
                        break;
                    case 2:
                        metodos.BurbujaMayor(array); 
                        break;
                    case 3:
                        metodos.BurbujaSeñal(array); 
                        break;
                    case 4:
                        metodos.Sacudida(array); 
                        break;
                    case 5:
                        metodos.Inserción(array);
                        break;
                    case 6:
                        metodos.InserciónBinaria(array);
                        break;
                    case 7:
                        metodos.Selección(array);
                        break;
                    case 8:
                        metodos.Shell(array);
                        break;
                    case 9:
                        metodos.quicksort_rapidoRecursivo(array);
                        break;
                    case 10:
                        metodos.heapsort(array); 
                        break;
                    case 11:
                        Console.WriteLine("Adiós");
                        return; 

                }
            }
        }
    }
}
