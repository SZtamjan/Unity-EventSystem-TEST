using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameEvent onShoot;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onShoot.Raise();
        }
    }
}
