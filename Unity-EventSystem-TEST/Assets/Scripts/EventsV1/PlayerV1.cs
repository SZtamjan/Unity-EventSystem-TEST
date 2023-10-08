using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerV1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EventV1.Instance.Triggersth();
        }
    }

}
