using System;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using UnityEngine;

[Serializable]
public class CompendiumObject
{
    public COType coType;
    public string name;
    public SourceBook source;
    public List<CompendiumTag> tags;

    public CompendiumObject()
    {
        coType = COType.CompendiumObject;
        tags = new List<CompendiumTag>();
    }

    //TODO: Implement own Serializer and Deserializer for each CompendiumObject class by reading out / writing the SimpleJSON node data accordingly. 
    public string Serialize()
    {
        return JsonUtility.ToJson(this);
    }

    public static T Deserialize<T>(string jsonObject)
    {
        return JsonUtility.FromJson<T>(jsonObject);
    }
}
