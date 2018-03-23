using System;


class Program
{
    static void Main(string[] args)
    {
        var input1 = Console.ReadLine().Split();
        var name1 = input1[0] + " " + input1[1];
        var place = input1[2];
        var city = input1[3];
        var tuple1 = new Threeuple<string, string, string>(name1, place, city);

        var input2 = Console.ReadLine().Split();
        var name2 = input2[0];
        var num2 = int.Parse(input2[1]);
        var isDrunk = input2[2] == "drunk";
        var tuple2 = new Threeuple<string, int, bool>(name2, num2, isDrunk);

        var input3 = Console.ReadLine().Split();
        var name3 = input3[0];
        var num3 = double.Parse(input3[1]);
        var town = input3[2];
        var tuple3 = new Threeuple<string, double, string>(name3, num3, town);

        Console.WriteLine(tuple1.ToString());
        Console.WriteLine(tuple2.ToString());
        Console.WriteLine(tuple3.ToString());
    }
}

