using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Buyables
{
    public Actor owner
    {
        get
        {
            return storedInContainer?.owner;
            //else return null;
        }
    }
    public ItemContainer storedInContainer;
}
