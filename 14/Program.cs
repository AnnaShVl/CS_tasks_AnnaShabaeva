//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

double a,b,c;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
c=a%b;
if (a%b==0)
{
    System.Console.WriteLine($"{a} кратно {b}");
}
else
{
       System.Console.WriteLine(c);
}