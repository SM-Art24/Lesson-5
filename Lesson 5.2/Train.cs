using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5._2
{
    interface TrainPassengers
    {
        public int TotalNumberOfPassengers();
    }
    interface TrainBaggage
    {
        public int TotalBaggage();
    }
    class Train : TrainBaggage, TrainPassengers
    {
        public RailwayCarriage[] array_train;

        public Train()
        { }
        public Train(RailwayCarriage[] array)
        {
            array_train = new RailwayCarriage[array.Length];
           
            for (int i = 0; i < array.Length; i++)
            {
                array_train[i] = new RailwayCarriage();
                array_train[i] = array[i];
                
            }
        }

        public int TotalNumberOfPassengers()
        {
            int result = 0;
            for (int i = 0; i < array_train.Length; i++)
                result += array_train[i].NumberOfPassengers;

            return result;
        }


        public int TotalBaggage()
        {
            int result = 0;
            for (int i = 0; i < array_train.Length; i++)
                result += array_train[i].Baggage;

            return result;
        }


        public void FindPassengers( (int, int) range)
        {
            for (int i = 0; i < array_train.Length; i++)
            {
                if (array_train[i].NumberOfPassengers >= range.Item1 && array_train[i].NumberOfPassengers <= range.Item2)
                    Console.WriteLine($"Вагон №{i} соответсвует заданому диапазону пассажиров. Количество пассажирова : {array_train[i].NumberOfPassengers}");
            }

        }


        public void SortRailwayCarriage()
        {
            for (int i = 0; i < array_train.Length - 1; i++)
                for (int j = 0; j < array_train.Length - 1; j++)
                    if (array_train[j].Сomfort > array_train[j + 1].Сomfort)
                    {
                        RailwayCarriage tmp = array_train[j];
                        array_train[j] = array_train[j + 1];
                        array_train[j + 1] = tmp;
                    }

            Console.Write("Вагоны отсортированы по уровню комфортности : ");

            for (int i = 0; i < array_train.Length; i++)
            {
                Console.Write($" {array_train[i].RailwayCarriageName} ");
            }
        }

        
    }
}
