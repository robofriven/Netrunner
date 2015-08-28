using UnityEngine;
using System.Collections;

public class armitage :  Skill
{
	bool inPlay;
    int tokens;

    public armitage() 
	{
		name = "Armitage Codebusting";
		description = "Place 12cr. from the bank when it is installed.  when there are no more credits on armitage codebusting, trash it.  10s, take 2cr from Armitage Codebusting.";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "Resource";
		type2 = "job";
		faction = "neutral";
		inPlay = false;
        
	}

    public override void effect()
    {
        if (tokens >= 2)
        {
            GameController gc = findGC();
            gc.timer(1);
            Runner runner = findRunner();
            tokens -= 2;
            runner.credits += 2;
        }
        if (tokens == 0)
        {
            // call the uninstall method.
        }
    }

    public override void onInstall()
    {
        tokens = 12;

    }
}

