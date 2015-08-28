using UnityEngine;
using System.Collections;

public class accessGlobalsec : Skill
{
	
	public accessGlobalsec() 
	{
		name = "Access to Globalsec";
		description = "Install for +1 Link";
		castTime = 10;
		corp = false;
		cost = 1;
		type = "resource";
		type2 = "link";
		faction = "neutral";
	}
	
	public override void effect()
	{
        return;
	}

    public override void onInstall()
    {
        Runner runner = findRunner();
        runner.links++;
    }

    public override void onUninstall()
    {
        Runner runner = findRunner();
        runner.links--;
    }
}

