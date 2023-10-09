using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        string collidedObjectTag = collision.gameObject.tag;

        Debug.Log("Collided with " + collidedObjectTag);
    }
}
