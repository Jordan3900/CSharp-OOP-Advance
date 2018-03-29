using System;
using System.Collections.Generic;
using System.Text;


public class ListyIterator
{
    private List<string> elements;
    private int index;
    public ListyIterator()
    {
        this.elements = new List<string>();
    }
  
    public List<string> Elements
    {
        get { return elements; }
        set { elements = value; }
    }

    public void Create(params string[] args)
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
}

