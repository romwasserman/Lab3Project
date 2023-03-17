using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    public GameObject coin;
    private float t = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (t < 3)
        {
            t += Time.deltaTime;
        }
        else
        {
            Instantiate(coin,new Vector3(Random.Range(-7.8f, 8.5f), 0.65f, Random.Range(-8.5f, 8.15f)), transform.rotation.normalized);
            t = 0f;
        }
    }
}
