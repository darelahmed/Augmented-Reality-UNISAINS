using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectRL : MonoBehaviour
{
    [SerializeField] private GameObject objectToRotate;
    [SerializeField] private float rotationSpeed = 40f;
    bool rotateStatus = false;

    public void RotateObject()
    {
        if(rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            objectToRotate.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
