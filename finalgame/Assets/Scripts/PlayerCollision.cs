using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerCollision : MonoBehaviour
{	 
    public CarMovement carMovement;
    public GameObject gameOverText;
    public GameObject restartButton;
    
    public ScoreSystem scoreSystem; 
    public SpawnManager spawnManager;
    
    public UIManager uiManager;
    public float fallThreshold = -5f;
	
    // Start is called before the first frame update
    void Start()
    {
       gameOverText.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y < fallThreshold)
        {
            uiManager.GameOver();
        } 
    }
    
     void OnCollisionEnter (Collision collisionInfo)
     {
         if (collisionInfo.collider.tag == "Obstacle")
         {
      	    carMovement.enabled = false;
      		
            gameOverText.SetActive(true);
            
            scoreSystem.GameOver();
            spawnManager.GameOver();
            
            restartButton.SetActive(true);
            
            uiManager.GameOver();
         }
      }
}
