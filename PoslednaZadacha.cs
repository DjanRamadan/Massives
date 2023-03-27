using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoslednaZadacha
{
    internal class PoslednaZadacha
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature");
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int min = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"Minimum temperature: {min}°C");
        }
    }
}
