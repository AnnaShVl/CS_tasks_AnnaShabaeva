//С клавиатуры вводятся три числа. Найти максимальное из трех чисел

double a,b,c, max;
string? s;
s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
s=Console.ReadLine();
c=Convert.ToDouble(s);
max=a;
if (b>max)
{ 
    max=b;
}
if (c>max)
{
    max=c;
}

 System.Console.WriteLine(max);