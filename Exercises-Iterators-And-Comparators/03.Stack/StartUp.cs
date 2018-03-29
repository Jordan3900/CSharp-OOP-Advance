using System;
using System.Linq;

class StartUp
{
    static void Main()
    {
        var stack = new Stack<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var cmd = args[0];

            switch (cmd)
            {
                case "Pop":
                    stack.Pop();
                    break;
                case "Push":
                    stack.Push(args.Skip(1).ToArray());
                    break;
                default:
                    break;
            }
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }

        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
    }
}

