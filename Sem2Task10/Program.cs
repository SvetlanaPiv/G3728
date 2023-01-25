// Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// int num = int.Parse(Console.ReadLine()??"0");
// int res = num/10;
// res = res%10;
// Console.WriteLine(res);
int num = int.Parse(Console.ReadLine()??"0");
if (num > 99 && num < 999)
{
    int res = num/10;
res = res%10;
Console.WriteLine(res);
}
else
{Console.WriteLine("Число не трехзначное");
}