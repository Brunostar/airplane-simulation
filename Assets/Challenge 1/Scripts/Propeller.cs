using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float rotationSpeed = 100;
    private Vector3 rotationDirection = new Vector3(0,0,1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate the propeller
        transform.Rotate(rotationDirection * rotationSpeed);
    }
}
