using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform playerTransform;

    private Transform _transform;
    private Transform _target;
    public static float speed = 5f;
    //public GameObject Player;
    //public Transform enemy;


    public virtual void hitPlayer()
    {

    }
    private void Start()
    {

    }
    private void Update()
    {
       //// var distance = Vector3.Distance(playerTransform.position, transform.position);
       // transform.position += transform.forward * speed * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            hitPlayer();
            Destroy(gameObject);
        }
    }
}
