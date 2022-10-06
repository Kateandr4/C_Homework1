// Показать числа от -N до N
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = number;
if (number>0)
{
    do
    {
        Console.WriteLine(count) ;
        count--;
    }
    while  (count > -number-1);
}
else
{
    do
    {
        Console.WriteLine(count) ;
        count++;
    }
    while  (count < -number+1);
}

