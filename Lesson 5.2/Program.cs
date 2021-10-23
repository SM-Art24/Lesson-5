using System;

namespace Lesson_5._2
{           /*7. Транспорт. Определить иерархию подвижного состава железнодорожного транспорта.
            * Создать пассажирский поезд. Подсчитать общую численность пассажиров и багажа.
            * Провести сортировку вагонов поезда на основе уровня комфортности.
            * Найти в поезде вагоны, соответствующие заданному диапазону параметров числа пассажиров.*/
    class Program
    {
      
        static void Main(string[] args)
        {
            RailwayCarriage[] array_train = new RailwayCarriage[5];
            array_train[0] = new RailwayCarriage("Локомотив",0,0,3);
            array_train[1] = new RailwayCarriage("Люкс", 18, 23, 1);
            array_train[2] = new RailwayCarriage("Купе", 36, 43, 2);
            array_train[3] = new RailwayCarriage("Плацкарт", 48, 52, 3);
            array_train[4] = new RailwayCarriage("Плацкарт", 54, 60, 3);
            Train train = new Train(array_train);

            for (int i = 0; i < train.array_train.Length; i++)
            {
                Console.WriteLine(train.array_train[i].ToString());
            }
            Console.WriteLine($"Общее количество пассажиров : {train.TotalNumberOfPassengers()}");
            Console.WriteLine($"Общее количество багажа : {train.TotalBaggage()}");
            train.FindPassengers( (20, 50));
            train.SortRailwayCarriage( );

          
        }
    }
}
