using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y+3, target.transform.position.z-7);
        transform.LookAt(target.transform);
    }
}