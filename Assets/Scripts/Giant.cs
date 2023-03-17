using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant : Enemy
{
    //public Transform Player;
    private Vector3 movement;
    private Rigidbody rb;

    public override void hitPlayer()
    {
        base.hitPlayer();
        Enemy.speed = 0.5f;
        PlayerInfo.health -= 5;
        Debug.Log(Enemy.speed);
    }
}
    //
