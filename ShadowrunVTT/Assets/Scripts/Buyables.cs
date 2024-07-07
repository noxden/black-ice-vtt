using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Buyables : CompendiumObject
{
    public int availabilityValue;
    public RestrictionLevel availabilityType;
    public RatingDependentInt cost;
}
