using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var box = new Box<string>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();

            box.Values.Add(input);

        }
        var element = Console.ReadLine();
        Console.WriteLine(box.Count(element));
    }
}

