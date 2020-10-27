using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDayInYear
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetDaysInYeaṛ̣̣̣̣(2020);
            var result2 = GetAllSundayInYear(2020);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        /// <summary>
        /// Tong so ngay trong nam
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int GetDaysInYeaṛ̣̣̣̣(int year)
        {
            DateTime date = new DateTime(year, 12, 31);
            return date.DayOfYear;
        }
        /// <summary>
        /// Tong so ngay chu nhat trong nam
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static int GetAllSundayInYear(int year)
        {
            int countSundayInYear = 0;
            for (int month = 1; month <= 12; month++)
            {
                DateTime dateTime = new DateTime(year, month, 1);
                int firstSundayOfMonth = (int)dateTime.DayOfWeek;
                if (firstSundayOfMonth != 0)
                {
                    dateTime = dateTime.AddDays((6 - firstSundayOfMonth) + 1);
                }
                while (dateTime.Month == month)
                {
                    countSundayInYear++;
                    dateTime = dateTime.AddDays(7);
                }
            }
            return countSundayInYear;
        }
    }
}
