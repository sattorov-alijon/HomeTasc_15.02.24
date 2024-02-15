void Divisior(int a)
{
    for (int i = 1; i <=a; i++)
    {
        if(a%i==0)
        {
            System.Console.WriteLine(i+" ");
        }
    }
}
int a=Convert.ToInt32(Console.ReadLine());
Divisior(a);