int even (int n)
{
    int cnt=0;
    for(int i=n; i>0; i/=10)
    {
        if ((i%10)%2==0)
        {
            cnt++;
        }
    }
    return cnt;
}

int odd(int n)
{
    int cnt=0;
    for(int i=n; i>0; i/=10)
    {
        if ((i%10)%2!=0)
        {
            cnt++;
        }
    }
    return cnt;
}

int digits(int n)
{
    int cnt=0;
    for(int i=n; i>0; i/=10)
    {
      
            cnt++;
      
    }
    return cnt;
}

int sum(int n)
{
    int sum=0;
    for(int i=n; i>0; i/=10)
    {
        sum+=i%10;   
    }
    return sum;
}
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("even= "+even(a));
Console.WriteLine("odd= "+odd(a));
Console.WriteLine("digits= "+digits(a));
Console.WriteLine("sum= "+sum(a));

