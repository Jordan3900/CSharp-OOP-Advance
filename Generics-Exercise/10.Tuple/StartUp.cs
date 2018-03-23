using System;


class StartUp
{
    static void Main(string[] args)
    {
        var input1 = Console.ReadLine().Split();
        var name1 = input1[0] +" "+ input1[1];
        var place = input1[2];
        var tuple1 = new Tuple<string, string>(name1, place);

        var input2 = Console.ReadLine().Split();
        var name2 = input2[0];
        var num2 = int.Parse(input2[1]);
        var tuple2 = new Tuple<string, int>(name2, num2);

        var input3 = Console.ReadLine().Split();
        var num3 = int.Parse(input3[0]);
        var floatNum = double.Parse(input3[1]);
        var tuple3 = new Tuple<int, double>(num3, floatNum);

        Console.WriteLine(tuple1.ToString());
        Console.WriteLine(tuple2.ToString());
        Console.WriteLine(tuple3.ToString());
    }
}

