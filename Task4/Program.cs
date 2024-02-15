int pow(int a,int b)
{
    int Pow=1;
    for(int i=1; i<=b; i++)
    {
        Pow=Pow*a;
    }
    return Pow;
}
System.Console.Write("x = ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int b=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(pow(a,b));
