// When building this class

using UnityEngine;
using System.Collections;

public class Agenda : CorpObject {

    new public string name;
    public string description;
	public string type;
	public string type2;
    public int points;
    public int advance;
    public int completionCost;
	public bool complete;
    public Corp corp;
	public GameController gameController;

    void Start()
    {
        advance = 0;
        complete = false;

        corp = GameObject.FindObjectOfType(typeof(Corp)) as Corp;
		gameController = GameObject.FindObjectOfType<GameController>() as GameController;
    }

    public void advanceAgenda()
    {
        if (corp.credits >= 1)
        {
            corp.credits --;
            advance ++;
        }


        if (advance == completionCost)
        {
			print("Agenda Scored");
			activate();
        }
    }

    public virtual void activate()
    {
        Debug.LogWarning("Agenda's activate() method not implemented.");
    }

	public Runner findRunner()
	{
		return GameObject.FindObjectOfType<Runner>() as Runner;
	}
}
