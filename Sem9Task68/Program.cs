// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int m = ReadData("Введите число m: ");
int n = ReadData("Введите число n: ");

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write("вычисление функции: " + Akkerman(m, n)); 
}

// расчет функции Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}