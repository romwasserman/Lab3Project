using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pepper : Fruit
{
    public override void Eat()
    {
        base.Eat();
        PlayerInfo.health += 1;
        Movement.MoveSpeed = 8;
        Debug.Log(Movement.MoveSpeed);
    }


    }
