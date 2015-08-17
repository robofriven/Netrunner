using UnityEngine;
using System.Collections;

public class Advancement : Subroutine {

	int tokens;
	Ice ice;

	void Start () 
	{
		name = "Advancement";
		abbrName = name;
		description = "This can be advanced, +1 str each time advanced";
		tokens = 0;
		// TODO ice = ;  I have no idea how to find THE object this is attached to if this isn't a GameObject

	}

	void Update()
	{
		// Wait for click
			// on click corp.credits --
			// tokens ++
			// ice.iceStr ++


	}
}
