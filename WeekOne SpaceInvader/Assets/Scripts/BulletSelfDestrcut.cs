using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSelfDestrcut : MonoBehaviour
{
    public float Bullettimer = 1f;

    // Update is called once per frame
    void Update()
    {
        Bullettimer -= Time.deltaTime;
        if (Bullettimer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
