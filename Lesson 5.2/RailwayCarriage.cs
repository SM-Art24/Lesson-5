using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._2
{
    class RailwayCarriage
    {
        public string RailwayCarriageName;
        public int Baggage;
        public int NumberOfPassengers;
        public int Сomfort;

        public RailwayCarriage()
        { }
        public RailwayCarriage(string Name, int number_of_passengers, int baggage, int comfort)
        {
            RailwayCarriageName = Name;
            Baggage = baggage;
            NumberOfPassengers = number_of_passengers;
            Сomfort = comfort;
        }

        public override string ToString()
        {
            return $"Вагон : {RailwayCarriageName}\nКоличество пассажиров : {NumberOfPassengers}" +
                $"\nКоличество багажа : {Baggage}\nКомфорт вагона : {Сomfort} класс\n";

        }
    }
}
