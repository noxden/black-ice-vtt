using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item
{
    public int capacity;
    public List<Modification> installedModifications;

    public Equipment()
    {
        coType = COType.Equipment;
        installedModifications = new List<Modification>();
    }
}
