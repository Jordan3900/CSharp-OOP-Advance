using System;
using System.Collections.Generic;
using System.Linq;

public class StrartUp
{
    static void Main()
    {
        var people = new List<Person>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split();
            var name = args[0];
            var age = int.Parse(args[1]);
            var town = args[2];

            people.Add(new Person(name, age, town));
        }

        var index = int.Parse(Console.ReadLine()) - 1;

        var person = people[index];

        if (people.Where(x => x.CompareTo(person) == 0).Count() > 1)
        {
            var equalPeople = people.Where(p => p.CompareTo(person) == 0).ToList().Count;
            var notEqualPeople = people.Where(p => p.CompareTo(person) != 0).ToList().Count;



            if (equalPeople > 0)
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }
            
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
}

