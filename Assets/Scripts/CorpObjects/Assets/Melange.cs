using UnityEngine;
using System.Collections;

public class Melange : Asset
{
	public bool isReady;

	void Start()
	{
		type = "Asset";
		type2 = null;
		description = "Gain 7cr (30s cooldown)";
		isReady = true;

	}

	public void effect()
	{
		if (isReady)
		{
			corp.credits += 7;
			isReady = false;
			cooldown();
		}

	}

	void cooldown()
	{
		Debug.LogWarning("This will cooldown for 30s when I figure out how to do that.");
	}
	
} 
