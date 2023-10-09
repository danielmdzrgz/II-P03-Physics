using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if ((Input.GetKeyDown(KeyCode.UpArrow) || 
            Input.GetKeyDown(KeyCode.DownArrow) || 
            Input.GetKeyDown(KeyCode.LeftArrow) || 
            Input.GetKeyDown(KeyCode.RightArrow)) && 
            gameObject.name == "MyCube") {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 cubeMovement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
            transform.Translate(cubeMovement); 
        }
        
        if ((Input.GetKeyDown(KeyCode.W) || 
            Input.GetKeyDown(KeyCode.S) || 
            Input.GetKeyDown(KeyCode.A) || 
            Input.GetKeyDown(KeyCode.D)) && 
            gameObject.name == "MySphere") {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 sphereMovement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
            transform.Translate(sphereMovement); 
        }
    }
}
