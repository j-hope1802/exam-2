
var pers = new Person();
pers.Name = Console.ReadLine();
pers.SurName = Console.ReadLine();
pers.Age = Convert.ToInt32(Console.ReadLine());

var list = new List<object>();
list.Add(pers.SurName);
list.Add(pers.Name);
list.Add(pers.Age);


foreach (var pp in  list)
{
    Console.Write($"{pp} ");
}