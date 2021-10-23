using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Year
    {
        public int year { get; }

        public Year()
        { year = (int)DateTime.Now.Year; }

        public Year(int year)
        { this.year = year; }

        public bool CheckYearLeap()
        {
             if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                return true;
            else
                return false;
        }

        public override string ToString()
        { return year.ToString(); }
    }
}
