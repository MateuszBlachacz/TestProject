using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [ SerializeField ]
    private float speed = 800f;
    [ SerializeField ]
    private float jumpForce = 4500f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ControllerInput.self.keys[actions.forwardKey]))
        {
            rb.AddForce(Vector3.forward * Time.deltaTime * speed);
        } else if (Input.GetKey(ControllerInput.self.keys[actions.backwardKey]))
        {
            rb.AddForce(Vector3.back * Time.deltaTime * speed);
        } else if (Input.GetKey(ControllerInput.self.keys[actions.leftKey]))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * speed);
        } else if (Input.GetKey(ControllerInput.self.keys[actions.rightKey]))
        {
            rb.AddForce(Vector3.right * Time.deltaTime * speed);
        } else if (Input.GetKeyDown(ControllerInput.self.keys[actions.jumpedKey]))
        {
            rb.AddForce(Vector3.up * Time.deltaTime * jumpForce);
        }


        
    }
}
