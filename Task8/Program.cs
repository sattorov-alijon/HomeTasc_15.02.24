﻿int min(int a,int b,int c,int d)
{
  if(a<=b && a<=c && a<=d)
  return a;
    else if(b<=a && b<=c && b<=d)
  return b;
   else if(c<=b && c<=a && c<=d)
  return c;
  else return d;
}
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
int d=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(min(a,b,c,d));