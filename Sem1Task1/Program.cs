// Задача №1
// Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число
// квадратом второго

// считываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
// считываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

// проверяем чтобы данные не были пустыми
if (inputNum1!=null && inputNum2!=null)
{
// // парсим введеное число
int number1 = int.Parse(inputNum1);
// // парсим введеное число
int number2 = int.Parse(inputNum2);
if (number1==number2*number2)
{
   Console.WriteLine("первое число квадрат второго");

}
else
{
   Console.WriteLine("первое число не квадрат второго");
}
}