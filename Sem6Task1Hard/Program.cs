// задача 1 HARD необязательная. На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. 
//Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
//является ли он прямоугольным, равнобедренным, равносторонним.


int a = ReadData("Введите первое число: ");
int b = ReadData("Введите второе число: ");
int c = ReadData("Введите третье число: ");

if (TriangleTest(a, b, c)) PrintData("Может быть сторонами треугольника.");
else PrintData("Не является сторонами треугольника.");

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

bool TriangleTest(int a, int b, int c)
{
    return ((a + b > c) && (a + c > b) && (b + c > a));
}
// находим периметр
double p = a + b + c;
Console.Write("Периметр p = " + p + " ");
// находим площадь
double s = Math.Sqrt(p / 2 * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));
Console.Write("Площадь s = " + s ); 



