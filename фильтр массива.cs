using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void sort (ref int [] arr) {
            int step = 0;
            bool b = true;
            while (b)
            
            {
                b = false;
                for (int i = 0; i<arr.Length; i += 2)
                {
                    if (i+1 == arr.Length)
                    {
                        break;
                    }
                    if (arr [i] > arr [i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        b = true;
                    }
                }
                for (int i =1; i < arr.Length; i += 2)
                {
                    if (i+1 == arr.Length)
                    {
                        break;
                    }
                    if (arr [i] > arr[i + 1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
            }

        }
        static void Main(string[] args)
        { 
            int [] arr = new int[100];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next() % 1000000;
                //Console.WriteLine(arr[i]);
            }
            sort(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
