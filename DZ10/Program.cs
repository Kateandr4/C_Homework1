// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("введите число из отрезка [10, 99]");
string a= Console.ReadLine();
if (a[0]>a[1])
{
    Console.WriteLine(a[0]);
}
else
{
    Console.WriteLine(a[1]);
}