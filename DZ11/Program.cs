// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("введите число 1");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите число 2, которое больше или равно числу 1");
int b = int.Parse(Console.ReadLine());
if (b>=a)
{
    if (b % a == 0)
    {
        Console.WriteLine("Число 1 кратно числу 2");
    }
    else
    {
    int c = b % a;
    Console.WriteLine("Остаток " + c );
    }
}
else Console.WriteLine("Числа заданы некорректно");