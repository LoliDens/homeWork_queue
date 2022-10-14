using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueWaitingTime = 10;
            int coutGranny;

            Console.Write("Введи количесто старушек в очерди: ");
            coutGranny = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Вы должны простоять:{coutGranny * queueWaitingTime / 60 } часов и {coutGranny * queueWaitingTime % 60} минут");
            Console.ReadKey();
        }
    }
}
