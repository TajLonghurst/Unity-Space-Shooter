using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Mytarget;
    // Update is called once per frame
    void Update()
    {
        if (Mytarget != null)
        {
            Vector3 Targpos = Mytarget.position;
            Targpos.z = transform.position.z;
            transform.position = Targpos;
        }
    }
}
