using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : Fruit
{

    public override void Eat()
    {
        base.Eat();
        PlayerInfo.health +=3;
        Movement.MoveSpeed = 4;
        Debug.Log(Movement.MoveSpeed);

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
