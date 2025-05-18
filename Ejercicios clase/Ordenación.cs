using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Ordenación
{
    class Ordenación
    {
        public void print(int[] array)
        {
            foreach (int k in array)
            {
                Console.Write(k + " ");
            }
            Console.WriteLine();
        } 

        public void BurbujaMenor(int[] array)
        {
            int n = array.Length - 1;
            int AUX; 

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        AUX = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = AUX;

                        print(array);
                    }
                }
            }
        }

        public void BurbujaMayor(int[] array)
        {
            int n = array.Length;
            int AUX;

            for (int i = (n - 1) ; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        AUX = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = AUX;

                        print(array);
                    }
                }
            }
        }

        public void BurbujaSeñal(int[] array) 
        {
            bool BAND = false;
            int N = array.Length;
            int i = 0;

            while ((i < (N)) && (BAND == false))
            {
                BAND = true;
                for (int j = 0; j < (N-1); j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int AUX = array[j];
                        array[j]= array[j + 1];
                        array[j + 1] = AUX;
                        BAND = false;
                        print(array); 
                    }

                }
                i = i + 1;  
            }          
        }
         public void Sacudida(int[] array)
        {
            int IZQ = 1;
            int DER = array.Length - 1;
            int AUX;
            int k = array.Length - 1;
            while (DER >= IZQ)
            {
                for (int i = DER; i >= IZQ; i--)
                {
                    if (array[i - 1] > array[i])
                    {
                        AUX = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = AUX;
                        k = i;

                        print(array); 

                    }
                }
                IZQ = k + 1;

                for (int i = IZQ; i <= DER; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        AUX = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = AUX;
                        k = i;
                        print(array); 

                    }
                }
                DER = k - 1;

            }
        }
        
        public void Inserción (int[] array)
        {
            int AUX;
            int k = array.Length - 1;
            int n = array.Length - 1;


            for (int i = 1; i <= n; i++)
            {
                AUX = array[i];
                k = i - 1;

                while ((k >= 1) && (AUX < array[k]))
                {
                    array[k + 1] = array[k];
                    k = k - 1;
                }
                array[k + 1] = AUX;

                print(array);
            }
        }

        public void InserciónBinaria(int[] array)
        {
            int IZQ;
            int DER;
            int AUX, j, m;
            int n = array.Length - 1;


            for (int i = 1; i <= n; i++)
            {
                AUX = array[i];
                IZQ = 1;
                DER = i - 1;

                while (IZQ <= DER)
                {
                    m = (IZQ + DER) / 2;

                    if (AUX <= array[m])
                    {
                        DER = m - 1;
                    }
                    else
                    {
                        IZQ = m + 1;
                    }
                }
                j = i - 1;

                while (j >= IZQ)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[IZQ] = AUX;

                print(array); 
            }
        }

        public void Selección(int[] array)
        {
            int menor, k;
            int n = array.Length;

            for (int i = 0; i <= (n - 1); i++)
            {
                menor = array[i];
                k = i;

                for (int j = (i + 1); j < n; j++)
                {
                    if (array[j] < menor)
                    {
                        menor = array[j];
                        k = j;
                    }
                }
                array[k] = array[i];
                array[i] = menor;

                print(array); 
            }
        }

        public void Shell(int[] array)
        {
            int i, AUX;
            bool band;
            int n = array.Length;
            int INT = n + 1;


            while (INT > 1)
            {
                INT = INT / 2;
                band = true; 
                
                while (band == true)
                {
                    band = false;
                    i = 0; 

                    while ((i + INT) < n)
                    {
                        if (array[i] > array[i + INT])
                        {
                            AUX = array[i];
                            array[i] = array[i + INT];
                            array[i + INT] = AUX;
                            band = true;
                            print(array);

                        }
                        i += 1;

                    }
                    

                }


            }
        }

        public void quicksort_rapidoRecursivo(int[] array)
        {
            quicksort_reduceRecursivo(0, array.Length-1, array);
        }

        public void quicksort_reduceRecursivo(int INI, int FIN, int[] array)
        {
            int izq, der, pos, aux;
            bool band;
            
            izq = INI;
            der = FIN;
            pos = INI;
            band = true; 

            while(band== true)
            {
                band = false;
                while ((array[pos] <= array[der]) && (pos < der))
                {
                    der--; 
                }
                if (pos < der)
                {
                    aux = array[pos]; 
                    array[pos] = array[der];
                    array[der] = aux;
                    pos = der; 

                    while (array[pos] >= array[izq] && pos > izq)
                    {
                        izq++; 
                    }

                    if (pos > izq)
                    {
                        band = true;
                        aux = array[pos];
                        array[pos] = array[izq]; 
                        array[izq] = aux;
                        pos = izq;

                        
                    }

                     
                }
                print(array);
            }

            if ((pos - 1) > INI)
            {
                quicksort_reduceRecursivo(INI,pos-1,array); 
            }
            if(FIN > (pos + 1))
            {
                quicksort_reduceRecursivo(pos + 1, FIN, array); 
            }

        }

        public void heapsort_insert(int[] array)
        {
            int k, aux;
            bool band; 

            for(int i = 1; i < array.Length; i++)
            {
                k = i;
                band = true; 

                while (k>0 && band == true)
                {
                    band = false; 

                    if (array[k] > array[k / 2])
                    {
                        aux = array[k / 2];
                        array[k / 2] = array[k];
                        array[k] = aux;
                        k = k / 2;
                        band = true; 
                    }
                    
                }
                print(array);
            }
        }

        public void heapsort_delete(int[] array)
        {
            int aux, izq, der, k, ap;
            bool BOOL; 

            for (int i = array.Length - 1; i >= 1; i--)
            {
                aux = array[i]; 
                array[i] = array[0];
                izq = 1; 
                der = 2; 
                k = 0; 
                BOOL = true; 

                while (izq < i && BOOL == true)
                {
                    int mayor = array[izq];
                    ap = izq;

                    if (mayor < array[der] && der < i)
                    {
                        mayor = array[der];
                        ap = der;
                    }

                    if (aux < mayor)
                    {
                        array[k] = array[ap];
                        k = ap; 
                    }
                    else
                    {
                        BOOL = false; 
                    }

                    izq = k * 2; 
                    der = izq + 1; 
                }
                array[k] = aux;
                print(array);
            }
        }

        public void heapsort(int[] array)
        {
            heapsort_insert(array);
            heapsort_delete(array);            
        }


    }
}
