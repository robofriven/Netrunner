using UnityEngine;
using System.Collections;

public class akamatsuMemChip : Skill {

    public akamatsuMemChip()
    {
        name = "Akamatsu Mem Chip";
        description = "+1 MEM";
        castTime = 10;
        corp = false;
        cost = 1;
        type = "Hardware";
        type2 = "chip";
        faction = "shaper";
        influence = 1;
    }

    public override void effect()
    {
        return;
	}

    public override void onInstall()
    {
        Debug.Log("onInstall called");
        Runner runner = findRunner();
        runner.mem ++;
    }

    public override void onUninstall()
    {
        Runner runner = findRunner();
        runner.mem --;
    }
}