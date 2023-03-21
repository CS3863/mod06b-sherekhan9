using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        xRange = 15.0f;
    }

    // Update is called once per frame
    public GameObject projectileprefab; // NOT DONE
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
       if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}