// Выяснить является ли число чётным

int a;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToInt32(s);
if (a%2==0)
{
     System.Console.WriteLine($"{a} четное");
}
else
{
     System.Console.WriteLine($"{a} нечетное");
}