using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Corp : MonoBehaviour
{
	public int agendaPts;
	public int credits;
	public new string name;
	public string description;		// flavor text
	public string identity;			// probably has a use
	public int maxInits;			// max cards in deck
	public int externalInits;		// max allowed from other corps
	public float timeSinceLastScore;// This is time since last agenda score
	public int badPub;

	public List<Ability> deck;	// used to store the deck
	public int handSize = 5;

    public List<Initiative> archives;

	public void Awake()
	{
		name = null;
		credits = 5;
		agendaPts = 0;
		maxInits = 45;				// some default values for starting hand size, etc
		externalInits = 15;
		handSize = 5;
		deck = buildDeck ();
		timeSinceLastScore = 0f;
		badPub = 0;
	}

	public virtual void effect()
	{
		Debug.LogError("Corps ability not set");
		throw new System.NotImplementedException();

	}

	public List<Ability> buildDeck()
	{
		Initiative aggressiveNegotiation = new aggressiveNegotiation();
		Initiative aggressiveNegotiation2 = new aggressiveNegotiation();
		Initiative archer = new archer();
		Initiative archer2 = new archer();
		Initiative beanstalkRoyalties = new beanstalkRoyalties();
		Initiative beanstalkRoyalties2 = new beanstalkRoyalties();
		Initiative beanstalkRoyalties3 = new beanstalkRoyalties();
		Initiative enigma = new enigma();
		Initiative enigma2 = new enigma();
		Initiative enigma3 = new enigma();
		Initiative hadriansWall = new hadriansWall();
		Initiative hadriansWall2 = new hadriansWall();
		Initiative hedgeFund = new hedgeFund();
		Initiative hedgeFund2 = new hedgeFund();
		Initiative hedgeFund3 = new hedgeFund();
		Initiative hostileTakeover = new hostileTakeover();
		Initiative hostileTakeover2 = new hostileTakeover();
		Initiative hostileTakeover3 = new hostileTakeover();
		Initiative hunter = new hunter();
		Initiative hunter2 = new hunter();
		Initiative iceWall = new iceWall();
		Initiative iceWall2 = new iceWall();
		Initiative iceWall3 = new iceWall();
		Initiative melangeMining = new melangeMining();
		Initiative melangeMining2 = new melangeMining();
		Initiative padCampaign = new padCampaign();
		Initiative padCampaign2 = new padCampaign();
		Initiative padCampaign3 = new padCampaign();
		Initiative postedBounty = new postedBounty();
		Initiative postedBounty2 = new postedBounty();
		Initiative priorityRequisition = new priorityRequisition();
		Initiative priorityRequisition2 = new priorityRequisition();
		Initiative priorityRequisition3 = new priorityRequisition();
		Initiative privateSecurity = new privateSecurity();
		Initiative privateSecurity2 = new privateSecurity();
		Initiative privateSecurity3 = new privateSecurity();
		Initiative researchStation = new researchStation();
		Initiative researchStation2 = new researchStation();
		Initiative scorchedEarth = new scorchedEarth();
		Initiative scorchedEarth2 = new scorchedEarth();
		Initiative securitySubcontract = new securitySubcontract();
		Initiative shadow = new shadow();
		Initiative shadow2 = new shadow();
		Initiative shadow3 = new shadow();
		Initiative shipment = new shipment();
		Initiative shipment2 = new shipment();
		Initiative wallofStatic = new wallOfStatic();
		Initiative wallofStatic2 = new wallOfStatic();
		Initiative wallofStatic3 = new wallOfStatic();

		 
		List<Ability> cards = new List<Ability>();
		List<Ability> shuffle = new List<Ability>();
		int rando = 0;

		cards.Add(aggressiveNegotiation);
		cards.Add(aggressiveNegotiation2);
		cards.Add(archer);
		cards.Add(archer2);
		cards.Add(beanstalkRoyalties);
		cards.Add(beanstalkRoyalties2);
		cards.Add(beanstalkRoyalties3);
		cards.Add (enigma);
		cards.Add (enigma2);
		cards.Add (enigma3);
		cards.Add(hadriansWall);
		cards.Add(hadriansWall2);
		cards.Add(hedgeFund);
		cards.Add(hedgeFund2);
		cards.Add(hedgeFund3);
		cards.Add(hostileTakeover);
		cards.Add(hostileTakeover2);
		cards.Add(hostileTakeover3);
		cards.Add(hunter);
		cards.Add(hunter2);
		cards.Add(iceWall);
		cards.Add(iceWall2);
		cards.Add(iceWall3);
		cards.Add(melangeMining);
		cards.Add(melangeMining2);
		cards.Add (padCampaign);
		cards.Add (padCampaign2);
		cards.Add (padCampaign3);
		cards.Add(postedBounty);
		cards.Add(postedBounty2);
		cards.Add(priorityRequisition);
		cards.Add(priorityRequisition2);
		cards.Add(priorityRequisition3);
		cards.Add(privateSecurity);
		cards.Add(privateSecurity2);
		cards.Add(privateSecurity3);
		cards.Add(researchStation);
		cards.Add(researchStation2);
		cards.Add(scorchedEarth);
		cards.Add(scorchedEarth2);
		cards.Add(securitySubcontract);
		cards.Add(shadow);
		cards.Add(shadow2);
		cards.Add(shadow3);
		cards.Add(shipment);
		cards.Add(shipment2);
		cards.Add(wallofStatic);
		cards.Add(wallofStatic2);
		cards.Add(wallofStatic3);
	
		int count = cards.Count;

		for (int i = 0; i < count; i++)
		{
			rando = Random.Range (0, cards.Count - 1);
			shuffle.Add (cards[rando]);
			cards.RemoveAt (rando);
		}

		return shuffle;

	}
}
