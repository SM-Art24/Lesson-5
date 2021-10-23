using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    public class Month
    {
        public int month { get; }
        public Month()
        {

            month = (int)DateTime.Now.Month;
        }
        public Month(int month)
        {
            if (month >= 1 && month <= 12)
                this.month = month;
            else
                throw new Exception("Ошибка, некорректные данные");
        }

        public int GetDayOfMonht(bool YearLeap)
        {
            return (int)(28.0 + (month + Math.Floor(month / 8.0)) % 2 + 2 % month + 2 * Math.Floor(1.0 / month));
        }
        public override string ToString()
        { return month.ToString(); }
    }
}
