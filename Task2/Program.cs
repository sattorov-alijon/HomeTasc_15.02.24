int add (int a,int b)
{
    return a+b;
}

int subtract (int a,int b)
{
    return a-b;
}

int multiply (int a,int b)
{
    return a*b;
}

int division (int a,int b)
{
    return a/b;
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("add= "+add(a,b));
Console.WriteLine("subtract= "+subtract(a,b));
Console.WriteLine("multiply= "+multiply(a,b));
Console.WriteLine("division= "+division(a,b));
