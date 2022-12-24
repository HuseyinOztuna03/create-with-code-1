using UnityEngine;

public class CarController : MonoBehaviour
{
    private float horizontalInput;
    private float forwardInput;

    private float turnSpeed = 35f;
    private float forwardForce = 20f;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(transform.forward * Time.deltaTime * forwardForce * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}