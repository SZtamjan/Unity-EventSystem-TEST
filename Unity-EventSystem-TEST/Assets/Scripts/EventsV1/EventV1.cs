using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventV1 : MonoBehaviour
{
    public static EventV1 Instance;

    private void Awake()
    {
        Instance = this;
    }

    public event Action SthHappened;

    public void Triggersth()
    {
        if (SthHappened != null)
        {
            SthHappened.Invoke();
            //sthHappened();    <-- Also correct, basically the same thing, but written differently
        }
    }
}
