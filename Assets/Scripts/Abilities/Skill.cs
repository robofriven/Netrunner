/*The class that controls all of the skills.
 * Requires: name, description, castTime(s), corp(T/F)
 */

using UnityEngine;
using System.Collections;

public class Skill : Ability
{
	public int    castTime;
	public bool   corp;

	public string type;  	 //Item subgroup like Event, or Hardware
	public string type2; 	 // Secondary subgroup such as "run" or "console"
	public int 	  str;		 // Strength of icebreakers
	public int    memCost;	 // memory cost of programs
	public string faction;	 // which class this card belongs to

	public GameController gameController;

	// Use this for initialization
	public Skill() {
		description = "This person was way too busy to bother putting in a description";
		castTime = 10;
		gameController = GameObject.FindObjectOfType<GameController>() as GameController;
	}

	public virtual void effect(int temp)
	{
		Debug.LogError("Skill has no effect");
		throw new System.NotImplementedException();
	}

	public void timer(int num)
	{
		// will execute the timer when finished for num times
		Debug.Log("This is the place where the timer will activate for the player.... when I figure that out.");
	}

	public Corp findCorp()
	{
		Corp corp = GameObject.FindObjectOfType(typeof(Corp)) as Corp;
		return corp;
	}
	
	public Runner findRunner()
	{
		return GameObject.FindObjectOfType(typeof(Runner)) as Runner;
	}

	public RunnerController findRC()
	{
		return GameObject.FindObjectOfType(typeof(RunnerController)) as RunnerController;
	}
}