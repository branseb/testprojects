using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie
{
    internal class Date


    {
        public static void Now()

        {
            var dayofweek = DateTime.Now.DayOfWeek;
            var day = DateTime.Now.Day;
            var month = DateTime.Now.Month -1;
            var year = DateTime.Now.Year;
            var hour = DateTime.Now.Hour;
            var minute = DateTime.Now.Minute;

            Console.WriteLine(dayofweek);
            Console.WriteLine(day + "." + month + "." + year);
            Console.WriteLine(hour + ":" + minute);


        }
    }
}
