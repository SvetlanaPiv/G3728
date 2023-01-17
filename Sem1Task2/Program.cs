//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Считываем данные с консоли
string? imputNumLine1 = Console.ReadLine();
string? imputNumLine2 = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputNumLine1!=null)
if(imputNumLine2!=null)
{
// Парсим введенное число
int imputNumberA = int.Parse(imputNumLine1);
int imputNumberB = int.Parse(imputNumLine2);

if (imputNumberA > imputNumberB)

Console.WriteLine("число 1 больше числа 2");
else 
Console.WriteLine("число 2 больше числа 1");
}
