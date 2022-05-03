using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string Gamescene;
    public string Credits;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(Gamescene);
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene(Credits);
    }

    public void CloseCredits()
    {
        SceneManager.LoadScene(Gamescene);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
