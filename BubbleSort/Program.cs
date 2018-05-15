using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 10, 3, 2, 4 };

            Console.WriteLine("Antes: 5, 10, 3, 2, 4");

            bool trocado;

            do
            {
                trocado = false;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i + 1];

                        nums[i + 1] = nums[i];

                        nums[i] = temp;

                        trocado = true;
                    }
                }
            } while (trocado == true);

            Console.Write("Depois: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }

            Console.ReadLine();
        }
    }
}
