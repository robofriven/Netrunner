using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// TODO Add a mulligan feature???

public class randomDealer
{
	List<string> runner;
	List<string> corp;

	public randomDealer()
	{
		runner = new List<string>();
		runner.Add ("diesel");
		runner.Add ("crypsis");
		runner.Add ("aesop");
		runner.Add ("armitage");
		runner.Add ("akamatsuMemChip");
		runner.Add ("batteringRam");
		runner.Add ("accessGlobalsec");
		runner.Add ("gordianBlade");
		runner.Add ("infiltration");
		runner.Add ("makersEye");
		runner.Add ("magnumOpus");
		runner.Add ("modded");
		runner.Add ("netShield");
		runner.Add ("personalTouch");
	}
	
	public List<string> deal (string faction, int handSize = 4) 
	{
		List<string> hand = new List<string>();
		int number = 0;
		if (faction == "runner")
		{
			for (int i = 0; i < handSize; i++)
			{
				number = Random.Range (0, runner.Count - 1);
				hand.Add (runner[number]);
				runner.RemoveAt (number);
			}
			foreach (string card in hand)
			{
				Debug.Log (card);
			}
		
		}
		else if(faction == "corp")
		{

		}
		else
		{
			Debug.LogError("Can't Deal, invalid faction.");
			throw new System.NotImplementedException();
		}

		return hand;
	}


}
