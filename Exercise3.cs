using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(1.0f, 0.0f, 0.0f);
    public float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = moveDirection.x * speed;
        float y = moveDirection.y * speed;
        float z = moveDirection.z * speed;

        transform.Translate(moveDirection * speed);
        // transform.Translate(moveDirection * speed, Space.World);
    }
}
