using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 20f; // Adjust this value to control the car's speed

    void FixedUpdate()
    {
        // Apply a constant forward force to the car's Rigidbody
        rb.transform.Translate(transform.forward * forwardForce * Time.deltaTime);
    }
}