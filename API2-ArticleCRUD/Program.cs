using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //public static int Monday = 0;
        static void Main(string[] args)
        {
            int DaystoAdd = -1;
            while (DaystoAdd < 0 || DaystoAdd > 500)
            {
                Console.WriteLine("Enter number of Days to add ");
                DaystoAdd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Day");
            string day = Console.ReadLine();

            DayOfWeek dayOfWeek = getDayOfWeek(day);

            string weekDay = AddDay(dayOfWeek, DaystoAdd);

            Console.WriteLine(" Calculated Day of the week is  :{0}", weekDay);

            return;
        }

        private static DayOfWeek getDayOfWeek(string day)
        {
            DayOfWeek dayOfWeek = 0;
            switch (day.ToLower())
            {
                case "sunday":
                    dayOfWeek = DayOfWeek.Sunday; break;
                case "monday":
                    dayOfWeek = DayOfWeek.Monday; break;
                case "tuesday":
                    dayOfWeek = DayOfWeek.Tuesday; break;
                case "wednesday":
                    dayOfWeek = DayOfWeek.Wednesday; break;
                case "thursday":
                    dayOfWeek = DayOfWeek.Thursday; break;
                case "friday":
                    dayOfWeek = DayOfWeek.Friday; break;
                case "saturday":
                    dayOfWeek = DayOfWeek.Saturday; break;
             
                default:  
                    break;
            }

            return dayOfWeek;
        }

        public static string AddDay(DayOfWeek day,int DaystoAdd)
        {
            int newDayOfWeek=(Convert.ToInt32(day) +DaystoAdd)%7;
             
                return ((DayOfWeek)newDayOfWeek).ToString();
          
        }
     
        public enum DayOfWeek
        {
           
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
          
        }
           
    }
}
