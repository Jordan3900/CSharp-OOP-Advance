using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        var lake = new Lake();
        lake.AddStone(numbers);

        Console.WriteLine(string.Join(", ", lake.Reverse()));
    }
}

