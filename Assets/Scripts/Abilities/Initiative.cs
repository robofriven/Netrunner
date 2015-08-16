/*Initiatives are the corp cards.  They will be handled much like skills are but with a few differences,
 * or maybe just a different subset, not entirely sure yet.
 */

// TODO RezInit needs to be made still

using UnityEngine;
using System.Collections;

public class Initiative : Ability
{

	public int rezCost;
	public int iceStr;
	public string type;
	public string type2;
	public string kind;
	public int advancement;
	public int adv;
	public int agendaPts;
	public int trashCost;
	public bool rezzed;
	public bool inHand;

	public MouseClick mouse;




	// Use this for initialization
	public Initiative ()
	{
		advancement 	= -1;
		adv				=  0;
		agendaPts 		= -1;
		trashCost 		= -1;
		cost			= -1;
		rezCost 		= -1;
		iceStr			= -1;
		rezzed 			= false;
		inHand 			= true;

		mouse = GameObject.FindObjectOfType<MouseClick>();
	}

	public void timer(int num)
	{
		// will execute the timer when finished, either for num s or num times
		Debug.Log("This is the place where the timer will activate for the player.... when I figure that out.");
	}
	public Corp findCorp()
	{
		Corp corp = GameObject.FindObjectOfType(typeof(Corp)) as Corp;
		return corp;
	}

	public CorpController findCorpController()
	{
		CorpController cc= GameObject.FindObjectOfType(typeof(CorpController)) as CorpController;
		return cc;
	}

	public Runner findRunner()
	{
		return GameObject.FindObjectOfType(typeof(Runner)) as Runner;
	}

	public void rezInit()
	{
		// if corp.credits >= rezCost
			// Prompt "Rez card?"
				// corp.credits -= rezCost
				// rezzed = true;
				// change to rezzed sprite
			// else return
			
	}

	public Vector2 mouseClick()
	{
		mouse.enabled = true;
		return Vector2.zero;

		// TODO Make a projector on mouse position
//		CorpController cc= GameObject.FindObjectOfType(typeof(CorpController)) as CorpController;
//		return cc.mousePoint();
	}
}