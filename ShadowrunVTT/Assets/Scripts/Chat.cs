using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Chat : MonoBehaviour
{
    public static Chat Instance { get; private set; }

    public List<string> messageHistory;

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

    public static void SendMessage(Actor actor, string message)
    {
        SendMessage(actor.name, message);
    }
    public static void SendMessage(Player player, string message)
    {
        SendMessage(player.name, message);
    }
    public static void SendMessage(string name, string message)
    {
        string fullString = $"{name}: {message}";
        Chat.Instance.messageHistory.Add(fullString);
    }

    public static void CreateLog()
    {
        string logString = "";
        
        foreach (string message in Chat.Instance.messageHistory)
            logString += message + "\n";

        Debug.Log(logString);
    }
}
