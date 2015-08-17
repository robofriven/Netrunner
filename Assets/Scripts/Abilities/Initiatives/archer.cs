using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class archer : Initiative
{
	private List<Subroutine> list = new List<Subroutine>();

	public archer()
	{
		name = "Archer";
		description = "As an Additional cost to rez Archer, the Corp must forfeit and agenda. 1) The Corp gains 2cr. 2) Trash 1 Program 3) Trash 1 Program 4) End the Run";
		rezCost = 4;
		type = "Ice";
		type2 = "Sentry-Destroyer";
		kind = "Weyland";
		influence = 2;
	}

	 public override void effect()
	{
		// Corp gains 2cr
		// trash a program
		// trash a program
		// end the run

		Debug.Log ("Archer");
		EventHandler.waitForClick();
		EventHandler.CLICKRECEIVED += fwInstantiate;
	}
	public void fwInstantiate(Vector2 position)
	{

		if (position == new Vector2(-2,-2) || position == new Vector2(-1,-1))
		{
			Debug.LogWarning ("Put it in a logical place! ... Popup and all that.");
			EventHandler.waitForClick();
		}
		else
		{
			Vector3 click = new Vector3(position.x, 2.5f, position.y);
			
			GameObject fw = PhotonNetwork.Instantiate ("firewall", click, Quaternion.identity, 0);
			Ice ice = fw.GetComponent<Ice>();

			list.Add(new Payment());
			list.Add(new TrashProgram());
			list.Add(new TrashProgram());
			list.Add(new EndRun());


			ice.build(name, rezCost, type, type2, iceStr, list);
		}
	}
}
