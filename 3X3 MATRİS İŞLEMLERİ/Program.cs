using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3X3_MATRİS_İŞLEMLERİ
{
    class Program
    {
        static void Main(string[] args)
        {
            //4- matris carpimi 

            int[,] array = new int[3, 3], carip = new int[3, 3], t = new int[3, 3]; ;
            Console.WriteLine("\t1. MATRİSİN ELEMANLARI GİRİNİZ");
            Console.WriteLine("\t------------------------------");
            Console.WriteLine("\n\t     _     _     _");
            Console.WriteLine("\n\t     _     _     _");
            Console.WriteLine("\n\t     _     _     _");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int m = 0; m < array.GetLength(1); m++)
                {
                    Console.SetCursorPosition(6 * m + 13, 3 + i * 2);
                    array[i, m] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            int[,] array2 = new int[3, 3];
            Console.WriteLine("\t2. MATRİSİN ELEMANLARI GİRİNİZ");
            Console.WriteLine("\t------------------------------");
            Console.WriteLine("\n\t     _     _     _");
            Console.WriteLine("\n\t     _     _     _");
            Console.WriteLine("\n\t     _     _     _");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int m = 0; m < array2.GetLength(1); m++)
                {
                    Console.SetCursorPosition(6 * m + 13, 3 + i * 2);
                    array2[i, m] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("\t    ---------------------------");
            Console.WriteLine("\t\tİŞLEMİ SEÇİNİZ\n\t\t- ÇARPMA İÇİN\t   1\n\t\t- TOPLAMA İÇİN\t   2\n\t\t- ÇIKARTMA İÇİN\t   3\n\t\t- BÖLME İÇİN\t   4 \n\t\t   YAZINIZ...");
            Console.WriteLine("\t    ---------------------------");
            Console.Write("\t\t-");
            int islem = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\t      BİRİNCİ MATRİS");
            Console.WriteLine("\t--------------------------");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int z = 0; z < array.GetLength(1); z++)
                {
                    Console.Write("\t{0,5}", array[i, z]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\t      İKİNCİ MATRİS");
            Console.WriteLine("\t--------------------------");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int z = 0; z < array2.GetLength(1); z++)
                {
                    Console.Write("\t{0,5}", array2[i, z]);
                }
                Console.WriteLine();
            }
            if (islem == 1)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                        carip[i, k] = 0;
                        for (int m = 0; m < array.GetLength(1); m++)
                        {
                            carip[i, k] +=array[i, m] * array2[m, k];
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("\t   İKİ MATRİSİN ÇARPIMI");
                Console.WriteLine("\t--------------------------");
                for (int i = 0; i < t.GetLength(0); i++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        Console.Write("\t    " + carip[i, m]);
                    }
                    Console.WriteLine();
                }
            }
            else if (islem == 2)
            {
                Console.WriteLine();
                Console.WriteLine("\t   İKİ MATRİSİN TOPLAMI");
                Console.WriteLine("\t--------------------------");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        carip[i, m] = array[i, m] + array2[i, m];
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int z = 0; z < array.GetLength(1); z++)
                    {
                        Console.Write("\t{0,5}", carip[i, z]);
                    }
                    Console.WriteLine();
                }
            }
            else if (islem == 3)
            {
                Console.WriteLine();
                Console.WriteLine("\t   İKİ MATRİSİN FARKI");
                Console.WriteLine("\t--------------------------");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int m = 0; m < array.GetLength(1); m++)
                    {
                        carip[i, m] = array[i, m] - array2[i, m];
                    }
                }
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int z = 0; z < array.GetLength(1); z++)
                    {
                        Console.Write("\t{0,5}", carip[i, z]);
                    }
                    Console.WriteLine();
                }
            }
            else if (islem == 4)
            {
                Console.WriteLine();
                Console.WriteLine("\t--------------------------");
                Console.WriteLine("\t   MATRİSLER BÖLÜNMEZ :)");
                Console.WriteLine("\t--------------------------");
            }
            Console.ReadKey();
        }
    }
}
