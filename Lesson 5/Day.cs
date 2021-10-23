using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Day
    {
        public int day { get; }
        public Day()
        {
            day = (int)DateTime.Now.Day;
        }
        public Day(int day)
        {
            if (day >= 1 && day <= 31)
                this.day = day;
            else
                throw new Exception("Ошибка, некорректные данные");
        }

        public override string ToString()
        { return day.ToString(); }
    }
}
