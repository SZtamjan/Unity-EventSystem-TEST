using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public int hp = 30;

    public void GotHit()
    {
        hp -= 10;
        if (hp <= 0) Destroy(gameObject);
    }
}
