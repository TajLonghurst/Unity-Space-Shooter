using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject PlayerInstance;
    public int NumbLives = 4;

    float RespawnTimer;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        NumbLives--;
        RespawnTimer = 1;
        PlayerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInstance == null && NumbLives > 1)
        {
            RespawnTimer -=Time.deltaTime;

            if (RespawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }
    void OnGUI()
    {
        if ( NumbLives > 1 || PlayerInstance!= null)
        {
            GUI.Label(new Rect(0,0,100,50), "Lives: " + NumbLives);
        }
        else if (NumbLives != 0 || PlayerInstance != null) 
        {
            GUI.Label(new Rect( Screen.width/2 - 50 ,  Screen.height/2 , 100, 50), "Game Over!");
        }
        
    }
}


