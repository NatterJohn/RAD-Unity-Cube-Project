using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    private float turningSpeed = 180;
    private float walkingSpeed = 5;
    public Transform cubeTemplate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        transform.position += walkingSpeed*transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.S))
        transform.position -= walkingSpeed * transform.forward * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        transform.position -= walkingSpeed * transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        transform.position += walkingSpeed * transform.right * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightShift))
        transform.position += transform.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftShift))
        transform.position -= transform.up * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
        transform.Rotate(transform.up, -turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        transform.Rotate(transform.up, turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow))
        transform.Rotate(transform.right, -turningSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow))
        transform.Rotate(transform.right, turningSpeed * Time.deltaTime);


    }
}

