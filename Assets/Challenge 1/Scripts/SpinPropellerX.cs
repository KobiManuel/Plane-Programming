using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float turnSpeed = 5000f;
    public float horizontalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        horizontalInput = Input.GetAxis("Vertical");


        transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);

    }
}
