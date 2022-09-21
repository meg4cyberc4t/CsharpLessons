using ConsoleApp1;


Cat a = new(100);
a.Eat(120);
Console.WriteLine(a.Weight);
a.Pee();
Console.WriteLine(a.Weight);

Console.WriteLine(Cat.GetCount());

for (int x = 0; x < 101; x++)
{
    a.Meow();
}

