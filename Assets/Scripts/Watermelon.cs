using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : Fruit
{
    // Start is called before the first frame update
    public override void Eat()
    {
        base.Eat();
        PlayerInfo.health += 4;
        Movement.MoveSpeed = 2;
        Debug.Log(Movement.MoveSpeed);
    }
}
