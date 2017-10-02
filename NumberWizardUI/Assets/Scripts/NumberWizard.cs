using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max = 100000;
	int min = 1;
	int guess = 50000;
	int maxGuesses = 20;

	public Text text;

	void Start () 
	{
		text.text = guess.ToString();
		max ++;	
	}
	
	public void GuessHigher()
	{
		min = guess;
		adjustGuess();
	}

	public void GuessLower()
	{
		max = guess;
		adjustGuess();
	}

	void adjustGuess()
	{
		guess = (max+min)/2;
		text.text = guess.ToString();
		maxGuesses --;
		if(maxGuesses == 0)
		{
			Application.LoadLevel("Win");
		}
	}
}
