// Показать четные числа от 1 до N
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 1;
 do
 {
    if (count % 2 == 0)
    {
    Console.WriteLine(count);
    }
    count++;
 }
while (count < number+1) ;


