using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{

   
    public class Date
    {
        public Day Day { get; }
        public Year Year { get; }
        public Month Month { get; }

        public Date(int day, int month, int year)
        {
            Day = new Day(day);
            Month = new Month(month);
            Year = new Year(year);
        }

        public Date()
        {
            Day = new Day();
            Month = new Month();
            Year = new Year();
        }
        
        public int GetDayOfWeek()
        {
            int result, account_year;
            account_year = Year.year - (14 - Month.month) / 12;

            result = 7000 - 4 + (Day.day + account_year + account_year / 4 - account_year / 100 + account_year / 400 + (31 * (Month.month + 12 * (14 - Month.month) / 12 - 2)) / 12);
            return result %7;
        }
        public static DayOfWeek valueOf(int index)
        {
            return (DayOfWeek)index;
        }
        public int GetDayOfYear()
        {
            int day = 0;
           
                
                for (int i = 1; i < Month.month; i++)
                {
                day += new Month(i).GetDayOfMonht(Year.CheckYearLeap());
                }
            day += Day.day;
                return day;
            
        }
        public int daysBetween(Date date)
        {
            DateTime start_date = new DateTime( Year.year,Month.month, Day.day);
            DateTime end_date = new DateTime(date.Year.year,date.Month.month,date.Day.day);
          
            return (int)Math.Abs((end_date - start_date).TotalDays);
        }
        public override string ToString()
        {
            return $"{Day}.{Month}.{Year}";

        }
    }

}
