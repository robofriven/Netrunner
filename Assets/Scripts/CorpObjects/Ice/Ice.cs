/* This will be the basic firewall class, right now I"m thinking that the best
 * way to handle firewalls is to build them dynamically with the different effects
 * that different firewalls can have.
 * 
 * So the Initiative card itself will handle instantiating the (correct) fireall
 * prefab and then adding the different quantities to it. (name, subroutines, etc)
 * 
 * Then the fireall object itself will deal with those and runner interaction
 * 
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ice : CorpObject {

	public string type;
	public string type2;
	public MouseClick mouseclick;

	int iceStr;

	
	public void build(string name, int cost, string typ, string typ2, int str, bool isRezzed = false)
	{
		this.name = name;
		rezCost = cost;
		type = typ;
		type2 = typ2;

	}
}