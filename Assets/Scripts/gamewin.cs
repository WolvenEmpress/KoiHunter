using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamewin : MonoBehaviour
{

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {

        //GameObject gameUI = GameObject.Find("GameUI");
        //gameUI.SendMessage("addPoint", SendMessageOptions.DontRequireReceiver);


        if (other.gameObject.CompareTag("Hook"))
        {
            health = health - 1;
            if (health <= 0)
            {
                SceneManager.LoadScene("Main Menu");

            }
        }




    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
