//Напишите программу, которая на вход принимает число и выдаёт, является ли 
//число чётным (делится ли оно на два без остатка).

//Считываем данные с консоли
string? imputNumLine = Console.ReadLine();

// Проверяем, чтобы данные не были пустыми
if(imputNumLine!=null)

{
// Парсим введенное число
int imputNumberA = int.Parse(imputNumLine);

if (imputNumberA%2 == 0)

Console.WriteLine("число четное");
else 
Console.WriteLine("число нечетное");
}

