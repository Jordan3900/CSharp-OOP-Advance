﻿using System;
using System.Linq;

class Startup
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
        var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

        box.Swap(indexes[0], indexes[1]);
        Console.Write(box.ToString());
    }
}

