using UnityEngine;
using System.Collections.Generic;

public class gordianBlade : Skill {

    GameController gc;

	public gordianBlade()
	{
        gc = findGC();

        name = "Gordian Blade";
		description = "1cr: Break code gate subroutine. 1cr: +1 str for the remainder of this run.";
		castTime = 10;
		corp = false;
		cost = 4;
		type = "program";
		type2 = "icebreaker";
		str = 2;
		memCost = 1;
		faction = "shaper";
		influence = 3;
	}
	
	public override void effect(int pay)
	{
        if (gc.state != "Run")
        {
            return;
        }
        var names = new List<string>();
        names.Add("+ Str");
        names.Add("Break Subroutine");
        icePopup.SetAmounts(2, names);
        icePopup.buttons[0].onClick.AddListener(() => plusStr(3));
    }

    public override void onInstall()
    {
        RunnerController rc = findRC();
        rc.cursorHidden = false;
        var names = new List<string>();
        names.Add("+ Str");
        names.Add("Break Subroutine");
        icePopup.SetAmounts(2, names);
        icePopup.buttons[0].onClick.AddListener(() => plusStr((int)icePopup.amounts[0].value));

    }

    public override void onCleanup()
    {
        
    }

    private void plusStr(int amount)
    {
        icePopup.textField.text = string.Format("You did it!!!  The number is... {0}", amount);

    }
}