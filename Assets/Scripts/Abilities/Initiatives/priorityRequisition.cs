using UnityEngine;
using System.Collections;

public class priorityRequisition : Initiative
{
	
	public priorityRequisition()
	{
		name = "Priority Requisition";
		description = "When you score this, you may rez a piece of ice ignoring the cost";
		type = "Agenda";
		type2 = "Security";
		kind = "Neutral";
		advancement = 5;
		agendaPts = 3;
	}
	
	public override void effect()
	{
		Debug.Log ("Priority Requisition");
		// Score Agenda
		// Rez piece of ice for free
	}
}