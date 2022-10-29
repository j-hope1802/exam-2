int n =Convert.ToInt32(Console.ReadLine());
int p=1; int sum=1;
for(int i=0;i<=n; i++)
p*=2;
sum=sum+p;
Console.WriteLine(sum);