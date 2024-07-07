using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Weapon
{
    public List<FireMode> availableModes;
    public int recoil;
    public List<Magazine> compatibleMags;
    public Magazine loadedMagazine;

    public bool LoadMagazine(Magazine mag)
    {
        // if mag.ammoCapacity && mag.type match any in compatibleMags[], accept
        return true;
    }
}
