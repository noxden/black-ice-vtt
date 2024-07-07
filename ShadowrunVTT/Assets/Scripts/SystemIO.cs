using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemIO : MonoBehaviour
{
    public const string SaveDataDir = "Assets/Compendium";

    public static void LoadCompendium()
    {
        List<string> files = new List<string>();

        string[] filePaths = System.IO.Directory.GetFiles($"{SaveDataDir}/");
        foreach (string filePath in filePaths)
        {
            string file = ReadFileAtPath(filePath);
            files.Add(file);
        }

        foreach (string jsonObject in files)
        {
            CompendiumObject cObject = Load<CompendiumObject>(jsonObject);  //< How to distinguish which CompendiumObject to cast them to?
            Compendium.Instance.entries.Add(cObject);
        }
    }

    #region Methods that utilize JsonUtility
    public static void Save(CompendiumObject cObject)
    {
        System.IO.Directory.CreateDirectory(SaveDataDir);

        string jsonObject = cObject.ToJSON();
        WriteFileAtPath(contents: jsonObject, path: SaveDataDir, title: cObject.name, extension: "json");
    }

    public static T Load<T>(string jsonObject)
    {
        return JsonUtility.FromJson<T>(jsonObject);
    }
    #endregion

    #region Methods that implement System.IO
    public static string ReadFileAtPath(string title, string path = SaveDataDir, string extension = "json")
    {
        if (System.IO.File.Exists($"{path}/{title}.{extension}"))
            return System.IO.File.ReadAllText($"{path}/{title}.{extension}");
        else
            return string.Empty;
    }

    public static void WriteFileAtPath(string contents, string path = SaveDataDir, string title = "0", string extension = "json")
    {
        System.IO.File.WriteAllText($"{path}/{title}.{extension}", contents);
    }
    #endregion
}
