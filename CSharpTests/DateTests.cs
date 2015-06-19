using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    class DateTests
    {
        public static void NumberOfDays()
        {
            var first = new DateTime(2015, 10, 10);
            var second = new DateTime(2015, 10, 20);

            var numberOfDays = second.Subtract(first);

            Console.WriteLine("Number of days " + numberOfDays);

        }

        /// <summary>
        /// http://geekswithblogs.net/BlackRabbitCoder/archive/2012/03/08/c.net-little-wonders-ndash-the-datetimeoffset-struct.aspx
        /// </summary>
        public static void DateTimesWithTimeZones()
        {
            // obviously, we'd read this from a file/stream/etc.
            string midnightMinus5Hours = "2012-03-01 00:00:00-05:00";//midnight minus 5 hours.


            
            var sevenPMThePreviousDay = DateTime.Parse(midnightMinus5Hours);//should be 7pm the day before.
            var sevenPMThePreviousDayUTC = TimeZoneInfo.ConvertTimeToUtc(sevenPMThePreviousDay);
            var theDay = sevenPMThePreviousDayUTC.Date;
            Console.WriteLine("Using DateTime {0}", sevenPMThePreviousDayUTC);



            // parse the birthday as a date time offset (doesn't convert to local)
            var dtOffset = DateTimeOffset.Parse(midnightMinus5Hours);
            // now if we want to use this to compare to other DateTime instances
            // locally, we can just use the Date property to retrieve the date
            // without respect to time or offset
            theDay = dtOffset.Date;
            Console.WriteLine("Using DateTimeOffSet {0}", dtOffset);

        }
    }
}
