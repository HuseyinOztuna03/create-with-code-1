using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject car;
    private Vector3 offset = new Vector3(0, 5, -9.5f);
    void LateUpdate()
    {
        transform.position = car.transform.position + offset;
    }
}
