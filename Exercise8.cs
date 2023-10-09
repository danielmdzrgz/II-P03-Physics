using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 90f;
    private Transform objective;

    // Start is called before the first frame update
    void Start()
    {
        objective = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float rotationAngle = inputHorizontal * rotationSpeed * Time.deltaTime;

        objective.Rotate(Vector3.up, rotationAngle);
        
        objective.Translate(Vector3.forward * speed * Time.deltaTime);

        // Debug.DrawRay(objective.position, objective.forward * 10f, Color.green);
    }
}
