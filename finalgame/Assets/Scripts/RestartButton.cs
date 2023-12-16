using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
	public ScoreSystem scoreSystem;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     public void RestartGame()
     {
     	scoreSystem.RestartTimer();
     	
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
