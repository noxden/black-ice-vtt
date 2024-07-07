using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Equipment
{
    public WeaponCategory weaponCategory;
    public int accuracy;
    public RatingDependentInt damageValue;
    public DamageType damageType;
    public DamageElement damageElement;
    public int armorPenetration;
}
