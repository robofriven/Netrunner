using UnityEngine;
using System.Collections;

public class crypsis : Skill
{
	public int virus;
    GameController gc;
    Runner runner;


    public crypsis()
	{
		name = "Crypsis";
		description = "1cr: break ice subroutine 1cr: +1 str. 10s: place 1 virus counter on cypsis. When an encounter with a piece of ice in which you used cyrpsis ends, remove 1 virus from Crypsis or trash Crypsis";
		castTime = 10;
		corp = false;
		cost = 2;
		type = "Program";
		type2 = "icebreaker";
		faction = "neutral";
		str = 0;
		memCost = 1;
		virus = 0;

        gc = findGC();
        runner = findRunner();

    }
	
	public override void effect()
	{
		Debug.Log("Crypsis");

        if (gc.state == "Play")
        {
            gc.timer(1);
            virus++;
        }
        else if (gc.state == "Run")
        {
            Debug.Log("Popup with options for how much to pay into what");
            Debug.Log("I still don't know how to make this damned thing break firewalls properly");
        }
	}
}
