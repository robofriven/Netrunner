using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Runner : MonoBehaviour
{
	new public string name;
	public string title; 		//Most Runners have a title like "Digital Tinker"
	public string description;  //Flavor Text
	public string type;			// Type of runner, anarchist, tinker, etc.
	public int links;  			// The number of built in links they have to avoid being traced
	public string identity; 	// Not sure how this works in game, but it's on the card
	public int maxSkills;  		// Max deck size
	public int externalSkills;	//Skills allowed from other types
	public int credits;			// amount of credits they have
	public int agendaPts;		// Victory pts (7 to win in normal game)
	public int tags;
	public hp health;
	public int handSize = 5;
	public List<Skill> deck;
	public int mem;
	public bool run;

	public void Awake()
	{
		credits = 5;
		agendaPts = 0;
		tags = 0;
		health = GameObject.FindObjectOfType(typeof(hp)) as hp;
		mem = 4;
		deck = buildDeck();
		run = false;
	}

	public virtual void effect()
	{
		Debug.LogError("Runner has no skill");
		throw new System.NotImplementedException();
	}

	private List<Skill> buildDeck()
	{
		List<Skill> cards = new List<Skill>();
		List<Skill> shuffle = new List<Skill>();
		int rando = 0;

		cards.Add (new accessGlobalsec());
		cards.Add (new aesop());
		cards.Add (new akamatsuMemChip());
		cards.Add (new akamatsuMemChip());
		cards.Add (new armitage());
		cards.Add (new armitage());
		cards.Add (new armitage());
		cards.Add (new batteringRam());
		cards.Add (new batteringRam());
		cards.Add (new crypsis());
		cards.Add (new crypsis());
		cards.Add (new crypsis());
		cards.Add (new diesel());
		cards.Add (new diesel());
		cards.Add (new diesel());
		cards.Add (new gordianBlade());
		cards.Add (new gordianBlade());
		cards.Add (new gordianBlade());
		cards.Add (new infiltration());
		cards.Add (new infiltration());
		cards.Add (new infiltration());
		cards.Add (new magnumOpus());
		cards.Add (new magnumOpus());
		cards.Add (new makersEye());
		cards.Add (new makersEye());
		cards.Add (new makersEye());
		cards.Add (new modded());
		cards.Add (new modded());
		cards.Add (new netShield());
		cards.Add (new netShield());
		cards.Add (new personalTouch());
		cards.Add (new personalTouch());
		cards.Add (new pipeline());
		cards.Add (new pipeline());
		cards.Add (new rabbitHole());
		cards.Add (new rabbitHole());
		cards.Add (new sacrificial());
		cards.Add (new sacrificial());
		cards.Add (new sureGamble());
		cards.Add (new sureGamble());
		cards.Add (new sureGamble());
		cards.Add (new tinkering());
		cards.Add (new tinkering());
		cards.Add (new tinkering());
		cards.Add (new toolbox());

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
