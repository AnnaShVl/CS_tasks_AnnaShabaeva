// С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго 

double a,b;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a==b*b)
{ 
    System.Console.WriteLine("a is square b");
}
else
{
    System.Console.WriteLine("a isn't square b");
}

if (a*a==b)
{ 
    System.Console.WriteLine("b is square a");
}
else
{
    System.Console.WriteLine("b isn't square a");
}