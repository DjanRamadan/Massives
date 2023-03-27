using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive_zadachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature of the days of the week");
            int n = 7;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //var temptotal = arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }
            double average = (double)sum / n;
            Console.WriteLine($"Average temperature: {Math.Round(average)}°C");
        }
    }
}
