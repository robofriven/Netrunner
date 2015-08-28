using UnityEngine;
using System.Collections;

public class PriorityReq : Agenda 
{
	void Start()
	{
		name = "Priority Requisition";
		description = "When you score this, you may rez a piece of ice ignoring the cost";
		type = "Agenda";
		type2 = "Security";
		points = 3;
		completionCost = 5;
	}
	
	public override void activate()
	{
		Debug.Log ("Click on the Ice you want to Rez for free.");

		//Add to mouse listener
		// find out if Vector2 has an ice there
		// change the ice's rez cost to 0
		// corpObject.rez()

	}
}
