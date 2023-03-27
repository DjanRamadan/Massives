using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    internal class Massive
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            //int i = 0;
            //arr[i] = int.Parse(Console.ReadLine(); i++;
            //arr[i] = int.Parse(Console.ReadLine(); i++;
            //arr[9] = 12;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"elemnt {i} = {arr[i]}");
            }

            //easier and shorter way
            foreach (var item in arr) //item = arr[0];
            {
                Console.WriteLine(item);
            }

            string.Join(" ", arr);
        }
    }
}
