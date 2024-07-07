using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingDependentInt
{
    private Dictionary<int, int> values; // <int rating, int values>
    
    public int GetValue(int rating)
    {
        values.TryGetValue(rating, out var value);
        return value;
    }
}