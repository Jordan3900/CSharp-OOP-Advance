using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Stack<T> : IEnumerable<T>
{
    private List<T> elements;

    public Stack()
    {
        this.elements = new List<T>();
    }

    public List<T> Elements
    {
        get { return elements; }
        set { elements = value; }
    }


    public void Pop()
    {

        if (this.elements.Count == 0)
        {
            Console.WriteLine("No elements");
        }
        else
        {
           this.elements.RemoveAt(this.elements.Count - 1);
        }
    }

    public void Push(params T[] args)
    {
        this.elements.AddRange(args);
        
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.elements.Count - 1; i >= 0; i--)
        {
            yield return elements[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

