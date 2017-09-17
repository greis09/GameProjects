using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head,  but dont tell me!");
		
		var max = 1000;
		var min = 1;
		
		print("Pick a number between "+min+" and "+max);
		
		print("Is the number higher or lower than 500?");
		print("Press Up arrow for higher, down arrow for lower and return for equal");
			
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			print("Up arrow pressed");
		}
		
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			print("Down arrow pressed");
		}
		
		if(Input.GetKeyDown(KeyCode.Return))
		{
			print("The number is 500");
		}
	
	}
}
