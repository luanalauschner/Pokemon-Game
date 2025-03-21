using System;
using UnityEngine;

[Serializable]
public class Int2Val 
{
    public int current;
    public int max;

    public  Int2Val (int current, int max)
    {
        this.current = current;
        this.max = max;
    }
}
