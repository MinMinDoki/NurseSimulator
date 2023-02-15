using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //We'll move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Rotate(Vector3.up, speed * horizontalInput * Time.deltaTime);

        Vector3 pos = transform.position;
        if(pos.x > 15) { pos.x = 15; }
        if (pos.x < -15) { pos.x = -15; }
        if (pos.z > 17) { pos.z = 17; }
        if (pos.z < -1) { pos.z = -1; }
        transform.position = pos;
    }
}
