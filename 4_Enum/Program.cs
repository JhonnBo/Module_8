﻿namespace _4_Enum
{
    internal class Program
    {
        enum Day_Of_Week { Sunday , Monday, Thuesday, Wednesday, Thursday, Friday, Saturday };
        //enum Day_Of_Week : long { Sunday, Monday, Thuesday, Wednesday, Thursday, Friday, Saturday }; Установка нового базового типа

        static void Main(string[] args)
        {
            
            string[] day_of_week = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };
            Day_Of_Week i; // Объявляем переменную перечислимого типа.
                           // Используем переменную i для обхода всех членов перечисления
            for (i = Day_Of_Week.Sunday; i <= Day_Of_Week.Saturday; i++)
            {
                Console.WriteLine(i + " - это " + day_of_week[(int)i]);
            }
            Console.WriteLine();

            if (Enum.IsDefined(typeof(Day_Of_Week), (int)4))
            // При любом значении вне диапазона (например, 30) IsDefined вернет false
            {
                Day_Of_Week d = (Day_Of_Week)4;
            }
            i = (Day_Of_Week)Enum.Parse(typeof(Day_Of_Week), "Thursday");
            Console.WriteLine(i);
          
          }
    }
}