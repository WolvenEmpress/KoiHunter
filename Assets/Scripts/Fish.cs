using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float speed;
    public int health; 
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 4f);
    }
    public void OnTriggerEnter2D( Collider2D other )
    {

        //GameObject gameUI = GameObject.Find("GameUI");
        //gameUI.SendMessage("addPoint", SendMessageOptions.DontRequireReceiver);


         if(other.gameObject.CompareTag("Hook"))
        {
            health = health-1;
            if(health <= 0 ){
        Destroy(this.gameObject);
        
            }
        }    
    
        

    }

    
    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = this.transform.position + new Vector3(-speed, 0f, 0f);
        this.transform.position = newPosition;
    }
}
