using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max = 1000;
	int min = 1;
	int guess = 500;
	
	void Start () 
	{
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head,  but dont tell me!");
		
		print("Pick a number between "+min+" and "+max);
		
		guessNumber();
		print("Press Up arrow for higher, down arrow for lower and return for equal");
		max ++;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			adjustGuess();
			guessNumber();
		} else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			adjustGuess();
			guessNumber();
		} else if(Input.GetKeyDown(KeyCode.Return))
		{
			print("I won!!");
		}
	
	}
	void adjustGuess()
	{
		guess = (max+min)/2;
	}
	void guessNumber()
	{
		print(string.Format("Is the number higher or lower than {0} ?",guess));
	}
}
