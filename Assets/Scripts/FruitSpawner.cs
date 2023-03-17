using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject orange;
    public GameObject pepper;
    public GameObject watermelon;
    private float t = 0f; 
    private float b = 0f;

    private GameObject activeFruit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (b < 3)
        {
            b += Time.deltaTime;
        }
        else
        {
            Spawner();
            b = 0f;
        }
    }
    public void Spawner()
    {
        int r = Random.Range(0, 3);
        if (r == 0)
        {
            activeFruit = Instantiate(orange, new Vector3(Random.Range(-7.8f, 8.5f), 0.65f, Random.Range(-8.5f, 8.15f)), transform.rotation.normalized);
            t += Time.deltaTime;
            if (t == 3f)
            {
                Destroy(activeFruit);
            }
        }
        if (r == 1)
        {
            activeFruit = Instantiate(pepper, new Vector3(Random.Range(-7.8f, 8.5f), 0.65f, Random.Range(-8.5f, 8.15f)), transform.rotation.normalized);
            t += Time.deltaTime;
            if (t == 3f)
            {
                Destroy(activeFruit);
            }
        }
        if (r == 2)
        {
            activeFruit = Instantiate(watermelon, new Vector3(Random.Range(-7.8f, 8.5f), 0.7f, Random.Range(-8.5f, 8.15f)), transform.rotation.normalized);
            t += Time.deltaTime;
            if (t == 3f)
            {
                Destroy(activeFruit);
            }
        }

    }
}
