using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyV1 : MonoBehaviour
{

    public int hp = 30;
    
    void Start()
    {
        EventV1.Instance.SthHappened += GotShot;
    }

    private void GotShot()
    {
        print("I got shot");
        hp -= 10;
        if (hp <= 0) UnSubAndDestroy();
    }

    private void UnSubAndDestroy()
    {
        EventV1.Instance.SthHappened -= GotShot;
        Destroy(gameObject);
    }
    
}
