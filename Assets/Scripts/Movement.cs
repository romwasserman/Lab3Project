using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float MoveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * Time.deltaTime * MoveSpeed;
/*
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        transform.Rotate(transform.forward, Input.GetAxis("Mouse X")  * Time.deltaTime, Space.World);
        transform.Rotate(transform.right, Input.GetAxis("Mouse Y")  * Time.deltaTime, Space.World);

        // Add input/movement to position
        transform.position += transform.forward * inputZ * MoveSpeed * Time.deltaTime;
        transform.position += transform.right * inputX * MoveSpeed * Time.deltaTime;
*/
    }
}
