using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise12 : MonoBehaviour
{
    public Transform sphere;

    public float movementForce = 2f;

    private Rigidbody rbCylinder;

    // Start is called before the first frame update
    void Start()
    {
        rbCylinder = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = sphere.position - transform.position;
        direction.Normalize();
        direction.y = 0f;

        if (Input.GetKeyDown(KeyCode.I) || 
            Input.GetKeyDown(KeyCode.K) || 
            Input.GetKeyDown(KeyCode.J) || 
            Input.GetKeyDown(KeyCode.L))
        {
            float horizontalMovement = Input.GetAxis("Horizontal2");
            float verticalMovement = Input.GetAxis("Vertical2");
            direction = new Vector3(horizontalMovement, 0.0f, verticalMovement);
        }

        Vector3 movement = direction * movementForce;
        rbCylinder.AddForce(movement);

        transform.LookAt(sphere);
    }
}
