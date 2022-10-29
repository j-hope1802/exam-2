int  n;

n = Convert.ToInt32(Console.ReadLine());

var ar = new int[n];
for (int i = 0; i < n; i++)
{
    ar[i] = Convert.ToInt32(Console.ReadLine());
}

int mx=ar[0], end,mn=ar[0],start;
for (int i = 0; i < length; i++)
{
    if(mx<=ar[i])
    {
        mx = ar[i];
        end = mx;
    }
    if(mn>=ar[i])
    {
        mn = ar[i];
        mn = start;
    }
    for (int i = start; i < end; i++)
    {
        System.Console.Write(ar[i]);
    }

}