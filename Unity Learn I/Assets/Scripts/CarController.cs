using UnityEngine;

public class CarController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;

    public float turnSpeed;
    public float forwardForce = 20f;

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        
        transform.Translate(transform.forward * Time.deltaTime * forwardForce * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}