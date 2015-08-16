using UnityEngine;
using System.Collections;

public class Trace : Subroutine {

	public int str;


	void Start() 
	{
		name = "Trace";
		description = "Traces the player with a given strength";
		trace();
	}

	void trace()
	{
		Debug.Log("Running Trace Program, because it's set to auto run for testing purposes");

		// poll both players for amount of credits invested.
		// corp.credits -= payment
		// str += payment

		// runner.credits -= payment
		// runnerStr = runner.link + payment

		// if (runnerStr >= str)
		//{
			// nothing
		//}

		// else runner.tag = true;
	}
}
