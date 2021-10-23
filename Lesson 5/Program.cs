using System;

namespace Lesson_5
{
    /*Вариант А 
Создать консольное приложение, удовлетворяющее следующим требованиям:
• Продемонстрировать в решении использование вложенных классов и перечисления.
• Можно сделать собственную архитектуру для решения поставленной задачи.
Создать объект класса Date, используя вложенные классы Год, Месяц, День. Методы: задать дату,
вывести на консоль день недели по заданной дате. День недели представить в виде перечисления.
Рассчитать количество дней, в заданном временном промежутке.
Т.е. в классе Date реализовать следующее:
public Date(int day, int month, int year)
public DayOfWeek getDayOfWeek()
public int getDayOfYear()
public int daysBetween(Date date)
В классе Year должна осуществляться проверка на високосность (можно реализовать в конструкторе) в результате,
установить значение для соотв. атрибута года.
В классе Month можно сделать метод который позволит узнать количество дней для того или иного месяца [1-12].
Метод можно использовать для подсчета дней в других методах: public int getDays(int monthNumber, boolean leapYear)
Создать статический метод: public static DayOfWeek valueOf (int index)
Для того чтобы можно было после математических расчетов использовать данный метод для преобразования индекса дня недели в соотв.
элемент перечисления.Переопределите методы toString() и equals().
*/
   
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Date first_date = new();
            Date second_date = new(28,10,2021);
            Date third_date = new(20, 5, 2021);
            Console.WriteLine($"Заданные даты \n{first_date}\n{second_date}\n{third_date}");
            
            Console.WriteLine($"День недели по заданной дате \n{first_date} - {Date.valueOf(first_date.GetDayOfWeek())}");
            Console.WriteLine($"Количество дней, в заданном временном промежутке \n{third_date} - {second_date} : {third_date.daysBetween(second_date)}");
        }
    }
}
