using UnityEngine;
using System.Collections;

public class archer : Initiative
{
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

		Vector2 click = mouseClick ();
		Vector3 position = new Vector3(click.x, 0, click.y);
		GameObject fw = PhotonNetwork.Instantiate ("firewall", position, Quaternion.identity, 0);
		fw.AddComponent<Ice>();
		Ice ice = fw.GetComponent<Ice>();
		Payment payment = ice.gameObject.AddComponent<Payment>() as Payment;
		TrashProgram trashProgram = ice.gameObject.AddComponent<TrashProgram>() as TrashProgram;
		TrashProgram trashProgram2 = ice.gameObject.AddComponent<TrashProgram>() as TrashProgram;
		EndRun endRun = ice.gameObject.AddComponent<EndRun>() as EndRun;
		ice.build(name, rezCost, type, type2, iceStr);
	}
}
