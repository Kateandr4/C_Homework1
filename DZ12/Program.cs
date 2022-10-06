// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("введите число 1");
int a = int.Parse(Console.ReadLine());
int a3=a ;
if (a>100)
{
 while (a3>999)
{
    a3=a3/10 ;
}
Console.WriteLine("третья цифра в числе = " + a3 % 10);
}
else
{
    Console.WriteLine("третьей цифры в числе нет");
}
