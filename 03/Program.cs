//с клавиатуры вводятся два числа a и b. Найти максимальное из них.

double a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a>b)
{ 
    System.Console.WriteLine($"{a} max");
}
else
{
    System.Console.WriteLine($"{b} max");
}
