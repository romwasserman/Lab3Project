using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public string FruitName;

 public virtual void Eat()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Eat();
            Destroy(gameObject);
        }
    }
}
