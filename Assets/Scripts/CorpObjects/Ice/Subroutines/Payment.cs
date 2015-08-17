using UnityEngine;
using System.Collections;

public class Payment : Subroutine {

	int payAmt;
	Corp corp;

	void Start () 
	{
		name = "payment";
		abbrName = name;
		description = "This is the payment subroutine!";
		corp = this.gameObject.GetComponent<Corp>();
	}

	void pay()
	{
		corp.credits += payAmt;
	}

}
