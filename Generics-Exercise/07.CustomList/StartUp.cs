using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var box = new Box<string>();

        var input = Console.ReadLine();

        while (input != "END")
        {
            var args = input.Split();

            var cmd = args[0];

            switch (cmd)
            {
                case "Add":
                    box.Values.Add(args[1]);
                    break;
                case "Max":
                    Console.WriteLine(box.Values.Max());
                    break;
                case "Min":
                    Console.WriteLine(box.Values.Min());
                    break;
                case "Greater":
                    Console.WriteLine(box.Greater(args[1]));
                    break;
                case "Swap":
                    box.Swap(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Contains":
                    Console.WriteLine(box.Values.Contains(args[1]));
                    break;
                case "Remove":
                    box.Values.RemoveAt(int.Parse(args[1]));
                    break;
                case "Print":
                    Console.WriteLine(string.Join(Environment.NewLine, box.Values));
                    break;
                default:
                    break;
            }

            input = Console.ReadLine();
        }
    }
}

