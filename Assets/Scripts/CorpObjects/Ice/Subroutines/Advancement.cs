using UnityEngine;
using System.Collections;

public class Advancement : Subroutine {

	int tokens;
	Ice ice;

	void Start () 
	{
		name = "Advancement";
		description = "This can be advanced, +1 str each time advanced";
		tokens = 0;
		ice = this.gameObject.GetComponent<Ice>();
	}

	void Update()
	{
		// Wait for click
			// on click corp.credits --
			// tokens ++
			// ice.iceStr ++


	}
}
