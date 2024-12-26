using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will make the objects rotate in its pplace.


public class BreadRotation : MonoBehaviour
{   public float xAngle, yAngle, zAngle;
    
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
