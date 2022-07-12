// Написать программу вычисления значения функции y = sin(a). (Класс Math)

double a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
b=Math.Sin(a);
System.Console.WriteLine($"{b}");