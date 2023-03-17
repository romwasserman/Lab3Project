using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheeta : Enemy
{
    public override void hitPlayer()
    {
        base.hitPlayer();
        Enemy.speed = 8f;
        PlayerInfo.health -= 2;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
