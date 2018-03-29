using System;
using System.Collections;
using System.Linq;

namespace _02.Collection
{
    class StartUp
    {
        static void Main( )
        {
            ListyIterator<string> listyIterator = new ListyIterator<string>();

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
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
