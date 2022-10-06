//Найти максимальное из трех чисел
Console.WriteLine("Введите число 1");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3");
int number3 = int.Parse(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    if (number3>number2)
    {
        Console.WriteLine("Максимальное число = " + number3);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + number2);
    }
}  
else
    if (number3>number1)
    {
        Console.WriteLine("Максимальное число = " + number3);
    }
    else
    {
        Console.WriteLine("Максимальное число = " + number1);
    }