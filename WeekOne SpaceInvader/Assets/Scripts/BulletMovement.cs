using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float maxBulletSpeed = 8f;
    void Update()
    {
        Vector3 pos = transform.position;
        Vector3 Velocity = new Vector3(0, maxBulletSpeed * Time.deltaTime, 0);
        pos += transform.rotation * Velocity;
        transform.position = pos;
    }
}
