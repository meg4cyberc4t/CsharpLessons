namespace ConsoleApp1;

public class Cat
{
    public Cat(double weight)
    {
        Weight = weight;
        _weightEatenFood = 0;
        Health = 100;
        _isAlive = true;
        _isAte = false;
        Color = CatColor.Red;
        _count += 1;
        _initialWeight = weight;
    }

    public Cat(Cat anotherCat)
    {
        Weight = anotherCat.Weight;
        _weightEatenFood = anotherCat._weightEatenFood;
        Health = anotherCat.Health;
        _isAlive = anotherCat._isAlive;
        _isAte = anotherCat._isAte;
        Color = anotherCat.Color;
        _count += 1;
    }

    private static Cat GetKitten()
    {
        return new Cat(1100.0);
    }


    public void Eat(double eatWeight)
    {
        if (!_isAlive)
        {
            Console.WriteLine("Кошка давно мертва");
            return;
        }

        _isAte = true;
        Weight += eatWeight;
        _weightEatenFood += eatWeight;
    }

    public void Meow()
    {
        if (!_isAlive)
        {
            Console.WriteLine("Кошка давно мертва");
            return;
        }
        Console.WriteLine("Meow");
        Health -= 1;
        if (Health <= 0)
        {
            _isAlive = false;
        }
    }

    public void Pee()
    {
        if (!_isAlive)
        {
            Console.WriteLine("Кошка давно мертва");
            return;
        }

        Weight = _initialWeight;
        Console.WriteLine("Pee...");
    }

    public double GetEatenFood() => _weightEatenFood;

    public double Weight { get; set; }
    private readonly double _initialWeight;
    private double _weightEatenFood;
    private bool _isAte;

    public int Health { get; set; }

    public bool IsAlive() => _isAlive;
    private bool _isAlive;

    public bool HasTail() => true;

    private static int _count = 0;
    public static int GetCount() => _count;

    public CatColor Color { get; set; }

    public const int EyeCount = 2;
    public const int MinimumWeight = 1;
    public const int MaximumWeight = 130;
}