using System;

namespace homeWork_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int queueWaitingTime = 10;
            int numberGrendmathers;
            int waitingTimeInHours;
            int waitingTimeInMinutes;
            int numberMinutesInHour = 60;

            Console.Write("Введи количесто старушек в очерди: ");
            numberGrendmathers = Convert.ToInt32(Console.ReadLine());

            waitingTimeInHours = numberGrendmathers * queueWaitingTime / numberMinutesInHour;
            waitingTimeInMinutes = numberGrendmathers * queueWaitingTime % numberMinutesInHour;

            Console.WriteLine($"Вы должны простоять:{waitingTimeInHours} часов и {waitingTimeInMinutes} минут");
            Console.ReadKey();
        }
    }
}
