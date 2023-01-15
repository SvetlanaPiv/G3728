// Задача 0
//Напишите программу, которая на вход принимает
// число и выдаёт его квадрат (число умноженное на
// само себя). 

// считываем данные с консоли
string? inputNum = Console.ReadLine();

if (inputNum!=null)
{
// // парсим введеное число
//  int number = int.Parse(inputNum);
// // находим квадрат числа
//  //int result = number * number;
// int result = (int)Math.Pow(number,2);

// // выводим данные в консоль
//  Console.WriteLine(result);
 
 Console.WriteLine(Math.Pow(int.Parse(inputNum),2));
}