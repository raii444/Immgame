using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
	public TextMeshProUGUI scoreLabel;
	public GameObject gameOverText;
	
	float startTime;
	float timer;
	bool isGameOver = false;
	bool isGameStarted = false;
	
	
    // Start is called before the first frame update
    void Start()
    {
	gameOverText.SetActive(false);
	startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    	 if (isGameStarted && !isGameOver)
	    {
	        timer = Time.time - startTime;
	        scoreLabel.text = Mathf.Round(timer).ToString();
    	    }
    }
    
    public void GameOver()
    {
         gameOverText.SetActive(true);
         isGameOver = true;
    }
    
    public void StartGame()
    {
         isGameStarted = true;
    }
    
    public void StopTimer()
    {
         isGameStarted = false;
    }

    
    public void RestartTimer()
    {
         startTime = Time.time;
         
         timer = 0f;
         
         scoreLabel.text = "0";
         isGameOver = false;
         isGameStarted = false;
    }
}
