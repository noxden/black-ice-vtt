using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingDependentInt
{
    public int this[int rating]
    {
        get
        {
            if (values.TryGetValue(rating, out var value))
                return value;
            else
            {
                Debug.LogWarning($"There is no value for a rating of {rating}.");
                return -1;
            }
        }
        set
        {
            values[rating] = value;
        }
    }

    private Dictionary<int, int> values; // <int rating, int values>

    public RatingDependentInt()
    {
        values = new Dictionary<int,int>();
    }

    public Dictionary<int, int> GetAllKeyValuePairs()
    {
        return values;
    }
}