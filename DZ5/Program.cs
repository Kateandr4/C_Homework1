﻿// По заданному номеру дня недели вывести его название
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else
{
    if (day == 2)
    {
    Console.WriteLine("Вторник");
    }
    else
    {
        if (day == 3)
        {   
         Console.WriteLine("Среда");
        }
        else
        {
            if (day == 4)
            {       
                Console.WriteLine("Четверг");
            }
            else
            {
                if (day == 5)
                {
                    Console.WriteLine("Пятница!");
                }
                else
                {               
                    if (day == 6)
                    {
                        Console.WriteLine("Ура! Суббота");
                    }
                    else
                    {
                        if (day == 7)
                        {
                             Console.WriteLine("Ура! Воскресенье");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Введите другое число");
                        }
                    }
                }
            }
        }
    }
}
