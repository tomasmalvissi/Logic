using System;

namespace practice
{
    class Program
    {
        private enum Dias 
        {
            Lunes, Martes, Miercoles
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 1, 3 };
            (int, string) t1 = (1 , "tomy");
            var t2 = (2, 6 , 1 , 3);
            var t3 = (t2, arr);
            foreach (var item in t3.arr)
            {
                Console.WriteLine(t3.arr[item]); //error
            }

        }
        static int burbuja(int[] arr)
        {
            int salida = 0;
              
             for (int i = 0; i < arr.Length; i++)
             {
                try
                {
                   if (arr[i].CompareTo(arr[i + 1]) == 1)
                   {
                        int Temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = Temp;
                   }
                }
                catch (IndexOutOfRangeException){}
             }

                
            for (int i = 0; i < arr.Length; i++)
            {
                salida = arr[i];
                
            }

            return salida;

        }
        static void MaxMin() 
        {
            int[] arr = { 1, 2, 3, 5, 4 };
            int mayor = arr[0];
            int menor = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > mayor)
                {
                    mayor = arr[i];
                }
                else if (arr[i] < menor)
                {
                    menor = arr[i];
                }
            }
            Console.WriteLine(mayor);
            Console.WriteLine(menor);

        }
        static void split() 
        {
            string ciudades = "cancun||mexico||argentina||USA";
            string[] ciudad = ciudades.Split("||");
            for (int i = 0; i < ciudad.Length; i++)
            {
                if (ciudad[i] == "cancun")
                {
                    Console.WriteLine(ciudad[i]);
                }
            }
        }
        static void usoenum() 
        {
            Dias dia = (Dias)2;
            int diaa = (int)Dias.Lunes;
            Console.WriteLine(dia);
            Console.WriteLine(diaa);
        }
        static void sort() 
        {
            int[] arr = { 2, 1, 3, 5, 4 };
            string[] arr1 = { "tomy", "klk", "21", "a ver", "si" };
            Array.Sort(arr);
            Array.Sort(arr1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr1[i]);
            }
        }
        static void convert() 
        {
            int numero = 21;
            string texto = "4";

            string resultnum = Convert.ToString(numero);
            int resultext = Convert.ToInt32(texto);
            Console.WriteLine(resultnum);
            Console.WriteLine(resultext);
        }
        static void subtring() 
        {
            string t = "buen dia que tal soy tomas";
            string r = t.Substring(0, 4);
            Console.WriteLine(r);
        }
    }
}

