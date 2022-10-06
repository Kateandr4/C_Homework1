//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
if (number1 == number2*number2)
{
   Console.Write ("все верно, число  " + number1 + " является квадратом числа " + number2);
}
else
{Console.Write ("число " + number1 + " не является квадратом числа " + number2);
}

