// This is Parent class for all corp spawned objects (ice, agendas, firewalls, upgrades,
// future stuff, potatoes, whatever.

using UnityEngine;
using System.Collections;

public class CorpObject : MonoBehaviour
{
	public int rezCost;
	public bool isRezzed;


	public CorpObject () 
	{
		rezCost = 0;
		bool isRezzed = false;
	}

		// Check for clicking! (This will probably be in a different method)

		// when clicked check isRezzed

		// if (isRezzed) do things

		// if (!isRezzed && corp.credits >= rezCost)
			// ask if rez
				// rez();

	void rez()
	{
		Debug.Log("Card/Ice/Agenda/thing will be rezzed... as soon as I figure out how");

		isRezzed = true;
		// Change model or whatever to signify it is rezzed and know what it is...
		// Hover over popup maybe???
	}
}
