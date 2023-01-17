//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.


// считываем данные с консоли все три числа
string? inputNumA = Console.ReadLine();
string? inputNumB = Console.ReadLine();
string? inputNumC = Console.ReadLine();

// проверяем чтобы данные не были пустыми
if (inputNumA!=null && inputNumB!=null && inputNumC!=null)
{
// // парсим введеное число
int numberA = int.Parse(inputNumA);
int numberB = int.Parse(inputNumB);
int numberC = int.Parse(inputNumC);
if (numberA > numberB)
 { if (numberA > numberC)
  Console.WriteLine(numberA);
  else 
  Console.WriteLine(numberC);
 }
 else
 if (numberB > numberC) 
 Console.WriteLine(numberB);
 else 
 Console.WriteLine(numberC);
}