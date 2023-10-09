using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (gameObject.name == "MyCube") {
            GameObject sphere = GameObject.Find("MySphere");

            Vector3 spherePosition = sphere.transform.position;

            transform.LookAt(spherePosition);

            Vector3 moveDirection = spherePosition - transform.position;
            moveDirection.y = 0f;

            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
        
        if ((Input.GetKeyDown(KeyCode.W) || 
            Input.GetKeyDown(KeyCode.S) || 
            Input.GetKeyDown(KeyCode.A) || 
            Input.GetKeyDown(KeyCode.D)) && 
            gameObject.name == "MySphere") {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 sphereMovement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;
            // transform.Translate(sphereMovement);
            GetComponent<Rigidbody>().AddForce(sphereMovement * speed); 
        }
    }
}
