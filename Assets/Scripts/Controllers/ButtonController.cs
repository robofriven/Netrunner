using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonController : MonoBehaviour 
{

	//public Corp corp;
	//public CorpController corpController;
	List<Initiative> hand = new List<Initiative>();

	public void go(List<Initiative> corpHand)
	{
		//Debug.Log ("Go is Going");

		hand = corpHand;

//		if (hand.Count == 0)
//			Debug.Log ("hand is empty");
//		else
//		{
//			for (int i = 0; i < hand.Count; i++)
//			{
//				Debug.Log (hand[i].name);
//			}
//		}
	}

	public void intermediateButton(int buttNumber)
	{
//		Debug.Log ("Intermediate Button!");
//		Debug.Log(hand.Count);

		buttonMethod(buttNumber, ref hand);
	}

	public void buttonMethod(int buttNumber, ref List<Initiative> hand)
	{
		Debug.Log (hand[buttNumber].name);
	}
	
}
