using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float verticalAxisValue = Input.GetAxis("Vertical");
            Debug.Log("Vertical axis value is " + verticalAxisValue + 
                      "\nUpArrow: new vertical axis value is " + 
                      verticalAxisValue * speed);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            float verticalAxisValue = Input.GetAxis("Vertical");
            Debug.Log("Vertical axis value is " + verticalAxisValue + 
                      "\nDownpArrow: new vertical axis value is " + 
                      verticalAxisValue * speed);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float HorizontalAxisValue = Input.GetAxis("Horizontal");
            Debug.Log("Horizontal axis value is " + HorizontalAxisValue + 
                      "\nLeftArrow: new vertical axis value is " + 
                      HorizontalAxisValue * speed);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            float HorizontalAxisValue = Input.GetAxis("Horizontal");
            Debug.Log("Horizontal axis value is " + HorizontalAxisValue + 
                      "\nRightArrow: new vertical axis value is " + 
                      HorizontalAxisValue * speed);
        }

    }
}
