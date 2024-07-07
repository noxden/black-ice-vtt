using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    public Actor actor;
    public string name;
    public int value { private get; set; }
    public bool improvisable;
    public Attribute attribute;
    public SkillGroup skillGroup;
    public bool isSkillGroupLocked;

    public int GetModifier()
    {
        return value + actor.GetAttributeBonus(this.attribute) + actor.GetSkillGroupBonus(this.skillGroup);
    }
}
