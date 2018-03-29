using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T> : IEnumerable<T>
{
    private List<T> elements;
    private int index;
    public ListyIterator()
    {
        this.elements = new List<T>();
    }
  
    public List<T> Elements
    {
        get { return elements; }
        set { elements = value; }
    }

    public void Create(params T[] args)
    {
        elements.AddRange(args);
    }

    public bool Move()
    {
        

        if (HasNext())
        {
           this.index++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool HasNext()
    {
        if ((index + 1 ) < this.elements.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Print()
    {
        if (this.elements.Count > 0)
        {
            Console.WriteLine(this.elements[index]);
        }
        else
        {
            throw new InvalidOperationException("Invalid operation!");
        }
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(" ",this.elements));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.elements.Count; i++)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

