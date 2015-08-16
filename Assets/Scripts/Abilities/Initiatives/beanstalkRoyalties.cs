using UnityEngine;
using System.Collections;

public class beanstalkRoyalties : Initiative
{
	
	public beanstalkRoyalties()
	{
		name = "Beanstalk Royalties";
		cost = 0;
		description = "Gain 3cr";
		type = "operation";
		type2 = null;
		kind = "Weyland";
	}
	
	public override void effect()
	{
		Debug.Log ("Beanstalk!");

		timer(1);
		Corp corp = findCorp();
		corp.credits += 3;

	}
}
