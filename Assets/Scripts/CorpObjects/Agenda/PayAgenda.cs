using UnityEngine;
using System.Collections;

public class PayAgenda : Agenda {

    public int pay;

	void Start () 
    {
        name = "Agenda Payment";
        description = "This will pay 'pay' credits upon completion";
	}

    public void build(int pay, int cost, int points)
    {
        this.pay = pay;
        this.completionCost = cost;
    }

    public void activate()
    {
        corp.agendaPts += points;
        corp.credits += pay;
    }
	
}
