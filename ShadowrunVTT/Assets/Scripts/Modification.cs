using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modification : Item
{
    public int rating;
    public int capacityCost;

    public Modification(int rating, int capacityCost)
    {
        coType = COType.Modification;
        this.rating = rating;
        this.capacityCost = capacityCost;
    }
}
