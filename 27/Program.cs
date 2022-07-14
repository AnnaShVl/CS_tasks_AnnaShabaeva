// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число");
double number=Convert.ToDouble (Console.ReadLine());

Console.WriteLine("Введите целое число");
int B=Convert.ToInt32 (Console.ReadLine());

int n=2;
double s=number;


while (n<=B)
{
    number=number*s;
    n++;
}

Console.Write(number);