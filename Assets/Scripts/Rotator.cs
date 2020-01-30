using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); 

    }

}
