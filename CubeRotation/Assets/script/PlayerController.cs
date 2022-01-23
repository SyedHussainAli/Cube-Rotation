using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 10.0f;
    public float horizontalInput;
    public float forwardInput;
    public Vector3 scale = new Vector3(1, 1, 1);
    public Vector3 orignalScale;
    // Start is called before the first frame update
    void Start()
    {
        orignalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        BoxScale();

    }
    void BoxScale()
    {
        if (Input.GetKey(KeyCode.Space))
            transform.localScale += scale;
        if (Input.GetKeyUp(KeyCode.Space))
        {
            while(transform.localScale.x>orignalScale.x&&transform.localScale.y>orignalScale.y&&transform.localScale.z>orignalScale.z)
            {
                transform.localScale -=scale*0.003f;
              
            }
        }
            //transform.localScale = orignalScale;
    }
}
