// Удалить вторую цифру целого числа введенного с клавиатуры.

int a,b,c;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a%10;
c=a/100;

System.Console.WriteLine($"{c}{b}");
