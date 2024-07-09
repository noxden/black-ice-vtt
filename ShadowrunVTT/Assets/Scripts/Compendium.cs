using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compendium : MonoBehaviour
{
    public static Compendium Instance { get; private set; }
    public static List<CompendiumObject> all;

    private void Awake()    // Instantiate singleton instance
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(this);
    }
}
