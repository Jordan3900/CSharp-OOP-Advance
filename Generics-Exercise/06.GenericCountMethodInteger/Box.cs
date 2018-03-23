using System;
using System.Collections.Generic;
using System.Text;



public class Box<T> where T : IComparable
{
   

    public Box()
    {
        
        this.Values = new List<T>();
    }

    public List<T> Values { get; set; }

    public void Swap(int index1, int index2)
    {
        var temp = Values[index1];
        Values[index1] = Values[index2];
        Values[index2] = temp;

    }

    public int Count(T element) 
    {
        int count = 0;
        foreach (var value in this.Values)
        {
            if (value.CompareTo(element) > 0)
            {
                count++;
            }
        }
        return count;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var value in Values)
        {
            sb.AppendLine($"{value.GetType().FullName}: {value}");
        }
        return sb.ToString();
    }
}

