//18. По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.

//Подпрограмма
bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}

//ОСНОВНАЯ ПРОГРАММА
System.Console.WriteLine("Введите 2 числа");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());


if (Check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}

