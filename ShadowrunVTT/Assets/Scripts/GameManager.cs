using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player player;

    private void Start()
    {
        Buyables c = new Buyables();
        c.name = "bibbedibabbedibub";
        c.availabilityValue = 0;
        SystemIO.Save(c);

        CompendiumObject cObject = SystemIO.Load<CompendiumObject>(SystemIO.ReadFileAtPath("bibbedibabbedibub"));
        Debug.Log(cObject.name);
    }
}
