using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiativeTracker : MonoBehaviour
{
    public List<InitiativeTrackerEntry> initiativePass;
}

public class InitiativeTrackerEntry
{
    public Actor actor;
    public int initiative;
}