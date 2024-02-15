int max (int n)
{   
    int maximum=-9999999;
    for (int i = n; i >0; i/=10)
    {
        if (i%10>maximum)
        {
            maximum=i%10;
        }
    }
    return maximum;
}

int min (int n)
{   
    int minimum=9999999;
    for (int i = n; i >0; i/=10)
    {
        if (i%10<minimum)
        {
            minimum=i%10;
        }
    }
    return minimum;
}



int a=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(max(a)+"+"+min(a)+"="+(max(a)+min(a)));