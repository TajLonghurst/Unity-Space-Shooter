using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public float MaxSpeed = 3.5f;
    public float RotSpeed = 180f;
    float shipboundaryRadius = 0.6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        //Rotaing the ship
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;
        rot = Quaternion.Euler( 0, 0, z);
        transform.rotation = rot;

        //Moving the Ship
        Vector3 pos = transform.position;
        Vector3 Velocity = new Vector3(0, Input.GetAxis("Vertical") * MaxSpeed * Time.deltaTime, 0);
        pos += rot * Velocity;
        //Border Bounderies 
        if (pos.y + shipboundaryRadius > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipboundaryRadius;
        }
        if (pos.y - shipboundaryRadius < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipboundaryRadius;
        }
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos.x + shipboundaryRadius > widthOrtho)
        {
            pos.x = widthOrtho - shipboundaryRadius;
        }
        if (pos.x - shipboundaryRadius < -widthOrtho)
        {
            pos.x = -widthOrtho + shipboundaryRadius;
        }
        transform.position = pos;
    
    }
}

