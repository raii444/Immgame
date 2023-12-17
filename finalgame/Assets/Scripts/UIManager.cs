using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{	
    
    public GameObject startPage;
    public GameObject gameOverUI;
    
    public ScoreSystem scoreSystem;

    
    // Start is called before the first frame update
    void Start()
    {
         startPage.SetActive(true);
         gameOverUI.SetActive(false);
         
    }

     public void StartGame()
    {
      
        startPage.SetActive(false);
        scoreSystem.StartGame();
    }
    
    public void GameOver()
    {
        gameOverUI.SetActive(true);
        
        scoreSystem.StopTimer();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
