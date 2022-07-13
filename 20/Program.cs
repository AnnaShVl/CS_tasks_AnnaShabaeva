// 20.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

double x,y;
string? s;
s=Console.ReadLine();
x=Convert.ToDouble(s);
s=Console.ReadLine();
y=Convert.ToDouble(s);

if (x>0 && y>0)
{
    System.Console.WriteLine("Точка в первой четверти");
}

if (x<0 && y>0)
{
    System.Console.WriteLine("Точка во второй четверти");
}

if (x>0 && y<0)
{
    System.Console.WriteLine("Точка в третьей четверти");
}

if (x<0 && y<0)
{
    System.Console.WriteLine("Точка в четвертой четверти");
}