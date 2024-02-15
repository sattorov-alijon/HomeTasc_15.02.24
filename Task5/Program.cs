void swap(int a,int b)
{
    int c=a;
    a=b;
    b=c;
    System.Console.WriteLine(a+" "+b);
}
System.Console.Write("x = ");
int x=Convert.ToInt32(Console.ReadLine());
System.Console.Write("y = ");
int y=Convert.ToInt32(Console.ReadLine());
swap(x,y);


