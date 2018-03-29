using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var set1 = new SortedSet<Person>();
        var set2 = new HashSet<Person>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine().Split();
            set1.Add(new Person(tokens[0], int.Parse(tokens[1])));
            set2.Add(new Person(tokens[0], int.Parse(tokens[1])));
        }
        Console.WriteLine(set1.Count);
        Console.WriteLine(set2.Count);
    }
}

