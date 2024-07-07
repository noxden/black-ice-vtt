using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationHandler : MonoBehaviour
{
    public List<NotificationMessage> queue;
}

public class NotificationMessage
{
    public PopupMessageType type;
    public string content;
}