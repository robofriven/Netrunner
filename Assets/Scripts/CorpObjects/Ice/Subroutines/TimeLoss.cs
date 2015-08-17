using UnityEngine;
using System.Collections;

public class TimeLoss : Subroutine {

	// Use this for initialization
	void Start () {
		name = "Time Loss";
		abbrName = "timeLoss";
		description = "Causes a 10s 'backlash' after the run";
	}

	void Encountered () 
	{
		Debug.Log("Time Loss");
		// Will call timer(1) after the state changes from run
	}
}
