using UnityEngine;
using System.Collections;

public class PAD : Asset 
{
		void Start()
	{
		name = "PAD Campaign";
		type = "Asset";
		type2 = "Advertisement";
		description = "Gain 1 cr every 30s";
		
	}

	public void effect()
	{
		corp.credits ++;
		gameController.timer(3);
	}
}