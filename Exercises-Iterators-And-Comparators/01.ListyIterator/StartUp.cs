using System;
using System.Linq;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        ListyIterator listyIterator = new ListyIterator();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split();
            var cmd = args[0];
            
            switch (cmd)
            {
                case "Create":
                    listyIterator.Create(args.Skip(1).ToArray());
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext()); 
                    break;
                case "Move":
                    Console.WriteLine(listyIterator.Move()); 
                    break;
                case "Print":
                    listyIterator.Print();
                    break;
                default:
                    break;
            }
        }
    }
}

