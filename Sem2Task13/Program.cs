// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.
//System.Random numSintezator = new System.Random();
char[] digits = Console.ReadLine().ToCharArray();
  
 if (digits.Length >= 3)
   {
    Console.WriteLine("третья цифра: " + digits[2]);
   }
    else
   {
   Console.WriteLine("третьей цифры нет");
}

