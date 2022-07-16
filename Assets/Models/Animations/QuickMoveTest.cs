using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickMoveTest : MonoBehaviour
{
    public float forwardSpeed;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * forwardSpeed);
    }
}
