// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//Считываем данные с консоли
string? imputNumLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if(imputNumLine!=null)
{
// Парсим введенное число
int imputNumberA = int.Parse(imputNumLine);
// Вводим промежуточное значение
//int imputNumberC = imputNumberA*(-1);
// Выходные значения
string outNumLine = string.Empty;
//
//while(imputNumberC < imputNumberA)
for (int i = 2; i < imputNumberA; i=i+2)
{
outNumLine = outNumLine + i + ",";
//imputNumberC = imputNumberC + 1;
}
if (imputNumberA%2==0)

outNumLine=outNumLine+imputNumberA;
//outNumLine = outNumLine + imputNumberA;
Console.WriteLine(outNumLine);
}

