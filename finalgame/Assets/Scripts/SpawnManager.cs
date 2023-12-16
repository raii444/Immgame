using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{	
	public GameObject obstacle;

	public float delay = 1;
	
	public int start_z;
	public int end_z;
	
	
	bool spawn = true;
	bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
    
    	if (isGameOver)
	{
	    return;
        }
        
        if(spawn)
        {
        	StartCoroutine(spawn_obstacle());
        }
    }
    IEnumerator spawn_obstacle()
    {
    	spawn = false;
    	yield return new WaitForSeconds(delay);
    	
    	int z = Random.Range(start_z, end_z);
    	
    	GameObject obstacle_clone = Instantiate(obstacle, new Vector3(transform.position.x, 0, z), Quaternion.identity);
    	obstacle_clone.SetActive(true);
    	
    	spawn = true;
    }
  public void GameOver()
  {
    isGameOver = true;
  }
}
