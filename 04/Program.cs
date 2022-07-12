//По заданному с клавиатуры номеру дня недели вывести его название

int a;
string? s;
s=Console.ReadLine();//просит ввести число
a=Convert.ToInt32(s);//преобразует формат числа в int
if (a==1)
{
    System.Console.WriteLine("понедельник");
}

if (a==2)
{
    System.Console.WriteLine("вторник");
}

if (a==3)
{
    System.Console.WriteLine("среда");
}

if (a==4)
{
    System.Console.WriteLine("четверг");
}

if (a==5)
{
    System.Console.WriteLine("пятница");
}


if (a==6)
{
    System.Console.WriteLine("суббота");
}

if (a==7)
{
    System.Console.WriteLine("воскресенье");
}

