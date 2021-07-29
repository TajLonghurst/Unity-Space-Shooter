using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedByCollistion : MonoBehaviour
{
    public int health = 1;
    public float invPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;
    SpriteRenderer SpriteRend;

    void Start() 
    {
        correctLayer = gameObject.layer;
        SpriteRend =GetComponent<SpriteRenderer>();
        if (SpriteRend == null)
        {   
            SpriteRend = transform.GetComponentInChildren<SpriteRenderer>();
            if (SpriteRend == null)
            {
            Debug.LogError("Object '" + gameObject.name + "' + Has not sprite name.");
            }
        }
    }
    void OnTriggerEnter2D() {
        Debug.Log("Trigger!");

        if (invulnTimer <= 0)
        {
            health--;
            invulnTimer = invPeriod;
            gameObject.layer = 10;
        }
    }
    void Update() {

        if (invulnTimer > 0)
        {
            invulnTimer -= Time.deltaTime;
            if (invulnTimer <= 0)
            {
                gameObject.layer = correctLayer;
                if (SpriteRend != null)
                {
                    SpriteRend.enabled = true;
                }
                else
                {
                if (SpriteRend != null)
                {
                    SpriteRend.enabled = !SpriteRend.enabled;
                }
                }
            }
        }

        if (health <= 0)
        {
            Die();
        }   
        }
    void Die() {
        Destroy(gameObject);
    }
        
}
