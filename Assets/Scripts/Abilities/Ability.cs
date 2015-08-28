// Basic Ability class, holds things that both player types have
// and used for reference nonspecific player type

using UnityEngine;
using System.Collections;

public class Ability
{
	public string name;
	public int influence;
	public int cost;
	public string description;


	
	public virtual void effect()
	{
		Debug.LogError("Initiative has no effect method");
		throw new System.NotImplementedException();
	}

    public virtual void onCleanup()
    {
        return;
    }

}
