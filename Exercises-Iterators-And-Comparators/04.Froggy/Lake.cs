using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class Lake : IEnumerable<int>
{
    private List<int> stones;

    public Lake()
    {
        this.stones = new List<int>();
    }

    public List<int> Stones
    {
        get { return this.stones; }
        set { this.stones = value; }
    }

    public void AddStone(params int[] stones)
    {
        this.stones.AddRange(stones);
    }



    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < stones.Count; i++)
        {
            if (i % 2 == 1)
            {
                yield return stones[i];
            }
        }
        for (int i = stones.Count - 1; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                yield return stones[i];
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

