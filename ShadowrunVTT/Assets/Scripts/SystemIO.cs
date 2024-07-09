using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using Unity.Properties;
using Unity.VisualScripting;

public class SystemIO : MonoBehaviour
{
    public const string SaveDataDir = "Assets/Compendium";

    public static void Save(CompendiumObject cObject)
    {
        WriteFileAtPath(cObject.Serialize(), cObject.name);
    }

    public static void LoadCompendium()
    {
        List<string> files = new List<string>();

        string[] filePaths = System.IO.Directory.GetFiles($"{SaveDataDir}/");
        foreach (string filePath in filePaths)
        {
            string file = ReadFileAtPath(filePath);
            files.Add(file);
        }

        foreach (string fileContent in files)
        {
            List<CompendiumObject> compendium = Compendium.all;

            JSONNode parsedJson = JSON.Parse(fileContent);
            
            COType cotype;
            if (int.TryParse(parsedJson[0].Value, out int coIndex))
                cotype = (COType)coIndex;
            else
                throw new InvalidCastException($"Failed to parse CompendiumObjectType \"{parsedJson[0]}\". The JSON file might be corrupted. Skipping this file.");

            // Identify type and deserialize accordingly
            switch (cotype)
            {
                case COType.CompendiumObject:
                    compendium.Add(CompendiumObject.Deserialize<CompendiumObject>(fileContent));
                    break;
                case COType.PlayerCharacter:
                    compendium.Add(CompendiumObject.Deserialize<PlayerCharacter>(fileContent));
                    break;
                case COType.NonPlayerCharacter:
                    compendium.Add(CompendiumObject.Deserialize<NonPlayerCharacter>(fileContent));
                    break;
                case COType.Buyables:
                    compendium.Add(CompendiumObject.Deserialize<Buyables>(fileContent));
                    break;
                case COType.Item:
                    compendium.Add(CompendiumObject.Deserialize<Item>(fileContent));
                    break;
                case COType.Equipment:
                    compendium.Add(CompendiumObject.Deserialize<Equipment>(fileContent));
                    break;
                case COType.Clothing:
                    compendium.Add(CompendiumObject.Deserialize<Clothing>(fileContent));
                    break;
                case COType.Armor:
                    compendium.Add(CompendiumObject.Deserialize<Armor>(fileContent));
                    break;
                case COType.Weapon:
                    compendium.Add(CompendiumObject.Deserialize<Weapon>(fileContent));
                    break;
                case COType.MeleeWeapon:
                    compendium.Add(CompendiumObject.Deserialize<MeleeWeapon>(fileContent));
                    break;
                case COType.RangedWeapon:
                    compendium.Add(CompendiumObject.Deserialize<RangedWeapon>(fileContent));
                    break;
                case COType.Modification:
                    compendium.Add(CompendiumObject.Deserialize<Modification>(fileContent));
                    break;
                case COType.FirearmAccessory:
                    compendium.Add(CompendiumObject.Deserialize<FirearmAccessory>(fileContent));
                    break;
                case COType.Ammunition:
                    compendium.Add(CompendiumObject.Deserialize<Ammunition>(fileContent));
                    break;
                case COType.Magazine:
                    compendium.Add(CompendiumObject.Deserialize<Magazine>(fileContent));
                    break;
                case COType.Credstick:
                    compendium.Add(CompendiumObject.Deserialize<Credstick>(fileContent));
                    break;
                case COType.SIN:
                    compendium.Add(CompendiumObject.Deserialize<SIN>(fileContent));
                    break;
                case COType.Drug:
                    compendium.Add(CompendiumObject.Deserialize<Drug>(fileContent));
                    break;
                case COType.Drone:
                    compendium.Add(CompendiumObject.Deserialize<Drone>(fileContent));
                    break;
                case COType.Vehicle:
                    compendium.Add(CompendiumObject.Deserialize<Vehicle>(fileContent));
                    break;
                case COType.Cyberware:
                    compendium.Add(CompendiumObject.Deserialize<Cyberware>(fileContent));
                    break;
                case COType.Bioware:
                    compendium.Add(CompendiumObject.Deserialize<Bioware>(fileContent));
                    break;
                case COType.Metatype:
                    compendium.Add(CompendiumObject.Deserialize<Metatype>(fileContent));
                    break;
                case COType.Quirk:
                    compendium.Add(CompendiumObject.Deserialize<Quirk>(fileContent));
                    break;
                case COType.Action:
                    compendium.Add(CompendiumObject.Deserialize<Action>(fileContent));
                    break;
                default:
                    compendium.Add(CompendiumObject.Deserialize<CompendiumObject>(fileContent));
                    throw new ArgumentOutOfRangeException("Parsed CompendiumObjectType ID of \"{parsedJson[0]}\" did not resolve to any existing CompendiumObjectType. Reverting to fallback type.");
            }
        }
    }

    #region Reading and writing files
    public static string ReadFileAtPath(string title)
    {
        if (System.IO.File.Exists($"{SaveDataDir}/{title}.json"))
            return System.IO.File.ReadAllText($"{SaveDataDir}/{title}.json");
        else
            return string.Empty;
    }

    public static void WriteFileAtPath(string contents, string title)
    {
        System.IO.Directory.CreateDirectory(SaveDataDir);
        System.IO.File.WriteAllText($"{SaveDataDir}/{title}.json", contents);
    }
    #endregion
}
