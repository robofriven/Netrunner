// When building this class

using UnityEngine;
using System.Collections;

public class Agenda : CorpObject {

    new public string name;
    public string description;
    public int points;
    public int advance;
    public int completionCost;
    public int completionPoints;
    public bool complete;
    public Corp corp;

    void Start()
    {
        advance = 0;
        complete = false;

        corp = GameObject.FindObjectOfType(typeof(Corp)) as Corp;
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
            // Do whatever the agenda does on completion
        }
    }

    public virtual void activate()
    {
        Debug.LogWarning("Agenda's activate() method not implemented.");
    }
}
