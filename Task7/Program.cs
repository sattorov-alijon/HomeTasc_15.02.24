void fun(int  []Arr, int n)
{
  
    for(int i=0;i<Arr.Length;i++){

       Arr[i]=Arr[i]+n;
    }
    for(int i=0;i<3;i++)
Console.WriteLine( Arr[i]);
}
int n;
int[]Arr =new int[]{1,2,3};
n=Convert.ToInt32(Console.ReadLine());
fun(Arr,n);
