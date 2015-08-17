using UnityEngine;
using System.Collections;

public class EndRun : Subroutine {

	// Use this for initialization
	void Start () 
	{
		name = "End Run";
		abbrName = "endRun";
		description = "Ends the run";
	}

	public void encountered()
	{
		Debug.Log ("End Run has been encountered");

		/*
		if (!isRezzed)
		{
			if (corp.credits >= rezCost
		}
		*/
	}
}
