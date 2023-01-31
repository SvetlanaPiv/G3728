// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//пользователь вводит число N

//пользователь вводит число
Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

// метод считает сумму цифр
int SumSym(int num)
  {    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int res = 0;

    for (int i = 0; i < counter; i++){
      advance = num - num % 10;
      res = res + (num - advance);
      num= num / 10;
    }
   return res;
}
//вывод на экран ответа
int sumcifr = SumSym(num);
Console.WriteLine("Сумма цифр в числе N: " + sumcifr);