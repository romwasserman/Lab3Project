using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{
    public override void hitPlayer()
    {
        base.hitPlayer();
        Enemy.speed = 6f;
        PlayerInfo.health -= 4;
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
