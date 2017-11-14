using UnityEngine; 
using System.Collections; 


public class PlayerHealth : MonoBehaviour { 
	
	
	public int maxHealth = 3; 
	public int curHealth = 3; 
	
	public float healthBarLength; 
	
	// Use this for initialization 
	void Start () { 
		healthBarLength = Screen.width / 3; 
	} 
	
	// Update is called once per frame 
	void Update () { 
		AdjustCurrentHealth(curHealth); 
	} 
	
	void OnGUI() { 
		
		GUI.Box (new Rect (10, 10, healthBarLength, 20), curHealth + "/" + maxHealth); 
		
		
	} 
	
	
	public void AdjustCurrentHealth(int adj) { 
		curHealth += adj; 
		
		if(curHealth < 0) 
			curHealth = 0; 
		
		if (curHealth > maxHealth) 
			curHealth  = maxHealth; 
		
		if (maxHealth < 1) 
			maxHealth = 1;    
		
		healthBarLength = (Screen.width / 3) * (curHealth / (float)maxHealth); 
		
		
	} 
} 

