var calcul = new Calculator();
var a = Convert.ToInt32(Console.ReadLine());
var b = Convert.ToInt32(Console.ReadLine());
long n = Convert.ToInt64(Console.ReadLine());
System.Console.WriteLine(calcul.Factorial(n));
System.Console.WriteLine(calcul.Multiple(a, b));
System.Console.WriteLine(calcul.Division(a, b));