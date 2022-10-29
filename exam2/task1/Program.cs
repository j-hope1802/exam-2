int n;
n = Convert.ToInt32(Console.ReadLine());
var ar = new int[n];

for (int i = 0; i < n; i++)
{
    ar[i] = Convert.ToInt32(Console.ReadLine());

}
int count = 0;

for (int i = 1; i < n - 1; ++i) {

 if (ar[i] > ar[i + 1] && ar[i] > ar[i - 1]) ++count;
 Console.WriteLine(count);

}


