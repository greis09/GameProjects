using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max = 100000;
	int min = 1;
	int guess = 0;
	int maxGuesses = 21;

	public Text text;

	void Start () 
	{
		adjustGuess();
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
		guess = Random.Range(min, max+1);
		text.text = guess.ToString();
		maxGuesses --;
		if(maxGuesses == 0)
		{
			Application.LoadLevel("Lose");
		}
	}
}
