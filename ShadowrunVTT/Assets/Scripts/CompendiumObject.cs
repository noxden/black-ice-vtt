using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompendiumObject
{
    public string name;
    public SourceBook source;
    public CompendiumTag[] tags;

    public string ToJSON()
    {
        return JsonUtility.ToJson(new DATA_CompendiumObject(this));
    }
}

[Serializable]
public class DATA_CompendiumObject
{
    public string type;
    public string name;
    public SourceBook source;
    public CompendiumTag[] tags;

    public DATA_CompendiumObject(CompendiumObject cObject)
    {
        type = cObject.GetType().ToString();
        this.name = cObject.name;
        this.source = cObject.source;
        this.tags = cObject.tags;
    }
}
