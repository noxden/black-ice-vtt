using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player player;

    private void Start()
    {
        PlayerCharacter a = new PlayerCharacter();
        a.name = "Paul";
        SystemIO.Save(a);

        Buyables b = new Buyables();
        b.name = "Machine Gun";
        b.availabilityValue = 12;
        b.cost[0] = 1;
        SystemIO.Save(b);

        CompendiumObject c = new CompendiumObject();
        c.name = "bibbedibabbedibub";
        c.tags.Add(CompendiumTag.BuiltIn);
        SystemIO.Save(c);

        Buyables d = new Buyables();
        d.name = "adawdaw";
        d.tags.Add(CompendiumTag.BuiltIn);
        d.source = SourceBook.RunAndGun;
        SystemIO.Save(d);

        Equipment e = new Equipment();
        e.name = "Jacket";
        e.availabilityType = RestrictionLevel.None;
        e.installedModifications.Add(new Modification(rating: 12, capacityCost: 2));
        SystemIO.Save(e);

        CompendiumObject cObject = CompendiumObject.Deserialize<CompendiumObject>(SystemIO.ReadFileAtPath("bibbedibabbedibub"));
        Debug.Log(cObject.name);
    }
}
