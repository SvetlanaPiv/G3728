// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// метод возведения в степень
int Pow(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = res * numberA;
  }
    return res;
}

// метод умножения
int Umnoj(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = numberA * numberB;
  }
    return res;
}

// метод деления
int Delen(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = numberA / numberB;
  }
    return res;
}

// метод вычитание
int Vychet(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = numberA - numberB;
  }
    return res;
}

// метод сложение
int Sloj(int numberA, int numberB)
{
  int res = 1;
  for(int i=1; i <= numberB; i++)
  {
    res = numberA + numberB;
  }
    return res;
}
// просит пользователя ввести данные
  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());
// выводит ответ на экран
  int vstepen = Pow(numberA, numberB);
  Console.WriteLine("Ответ - в степень: " + vstepen);
// умножение
  int umnojenie = Umnoj(numberA, numberB);
  Console.WriteLine("Ответ - умножение: " + umnojenie);
// деление
int delenie = Delen(numberA, numberB);
Console.WriteLine("Ответ - деление: " + delenie);
// вычитание
  int vychitan = Vychet(numberA, numberB);
  Console.WriteLine("Ответ - вычитание: " + vychitan);
// сложение
int slojenie = Sloj(numberA, numberB);
Console.WriteLine("Ответ - сложение: " + slojenie);