using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string name;
    public Color color;
    public List<Actor> ownedActors;
    public Actor selectedActor;
    public PermissionLevel permissionLevel;

    public void SendMessageAsSelf(string message)
    {
        Chat.SendMessage(this, message);
    }

    public void SendMessageAsSelectedActor(string message)
    {
        Chat.SendMessage(selectedActor, message);
    }
}
