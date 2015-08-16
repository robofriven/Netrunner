using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HandController : MonoBehaviour {


	List<Ability> hand = new List<Ability>();
	Ability current;


	public void go(List<Ability> handIn)
	{
		hand = handIn;
	}


	public void buttonLinker(int buttNumber)
	{
		buttonMethod(buttNumber, ref hand);
	}


	public void buttonMethod(int buttNumber, ref List<Ability> hand)
	{
		current = hand[buttNumber];
		hand.Remove(current);
		current.effect();
	}

	public void tempTester()
	{
		Initiative archer = new archer();
		archer.effect();
	}
}
