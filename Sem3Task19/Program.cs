// №19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

//необходимо ввести число
Console.Write("Введите пятизначное число: ");
string? num = Console.ReadLine();
// метод определяет палиндромность
void CheckNumber(string number){
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"введеное число: {num} - палиндром.");
  }
  else Console.WriteLine($"введеное число: {num} - не палиндром.");
}
//проверяет количество символов в введеном числе
if (num!.Length == 5)
{
  CheckNumber(num);
}
else Console.WriteLine($"введите правильное число");