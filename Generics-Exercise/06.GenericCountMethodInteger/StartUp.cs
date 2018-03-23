using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var box = new Box<double>();

        for (int i = 0; i < n; i++)
        {
            var input = double.Parse(Console.ReadLine().Trim());

            box.Values.Add(input);

        }
        var element = double.Parse(Console.ReadLine());
        Console.WriteLine(box.Count(element));
    }
}

