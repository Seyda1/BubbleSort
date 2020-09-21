
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{//Şeyda Aybar
    //bubbleSort
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter  your array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("please enter  your array's elements...");
            for (int i = 0; i < size; i++)
            {Console.WriteLine(i + ".element:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            bubble(array);
            Console.WriteLine("sorted ARRAY:..\n");
            for (int i = 0; i < size; i++)
            {
                
                Console.WriteLine(" {0}", array[i]);
            }
            Console.ReadLine();
        }
        public static void bubble(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                int flag = 0;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = 1;
                    }

                }
                if (flag == 0)
                {
                    break;
                }
            }
        }
    }
}
