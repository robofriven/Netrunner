using UnityEngine;
using System.Collections;

public class batteringRam : Skill {

    GameController gc;
	
	public batteringRam() 
	{
		name = "Battering Ram";
		description = "1cr: +1 str for remainder of run. 2cr: Break up to 2 barrier subroutines";
		castTime = 10;
		corp = false;
		cost = 5;
		type = "program";
		type2 = "icebreaker";
		str = 3;
		memCost = 2;
		faction = "shaper";
		influence = 2;
        gc = findGC();
	}

    public override void effect()
    {

        Debug.Log("Ram has been battered");
        if (gc.state == "Play")
        {
            // Popup saying that you have to be on a run to use an icebreaker?
            return;
        }
        else if (gc.state == "Run")
        {

            // Use popup to give options
            // Have 1 button be a slider to increase the amount that you pay to increase???
            // Other button be "Pay 2 credits to break 2 subroutines.
        }
    }

    public override void onCleanup()
    {
        str = 3;
    }
	
}
