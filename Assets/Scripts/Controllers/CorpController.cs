/*This script is for controlling the Corp Player.  The very nature of this game is assymetric so it's
 * going to essentially be like programming 2 games, one from the runner's side and one from the Corp's.
 *
 * The Corp will need to have a bit of a headstart over the runner, I'm thinking maybe 30 seconds of set
 * up time for the runner to "jack into" the Corps mainframe to give him time to set up his main protections
 *
 * From then I'm hoping for a real time game with cooldowns to install the various goodies involved.
 *
 * The Corp will have a isometric view (not sure if camera will be controllable... probably not)
 * I want either a fog of war or just a blindspot where the corp can't see what the runner is doing
 *
 * After the runner encounters a piece of ice (or takes from the corp) the corp will be notified and get to see
 * the action unfold and will then choose to rez whatever pieces of ice he wishes and pay the cost.)
 *
 *
 *
 *
 * TODO:
 *
 * Everything!
 *
 * More specific...
 *
 * Isometric camera display
 * 	    Only one program allowed per chunk
 * 		Get to place anywhere, or start at base as in card game???   ******** *
 * Have all of the cards made.
 *
 * Board positions...
 * Draw pile (R&D)
 * Archives (Discard)
 * 4 servers, each with "firewall" positions
 *
 *
 */
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CorpController : MonoBehaviour
{

	// Public Variables
	//Completed Agendas
	//Cards in deck (5 cards in hand to start)
	Corp corp;
	public List<Ability> deck;
	public List<Ability> hand;
	HandController handController;
	public Projector projector;

	// Use this for initialization
	void Start()
	{
		handController = GameObject.FindObjectOfType<HandController>();

		deck = new List<Ability>();
		hand = new List<Ability>();
		hand = deal();

		handController.go(hand);
	}

	// Mouse click defaults to 10 unit chunking.. returns if value of -1, -1 is
	//returned than the map was not clicked on.  Might have it return different values
	// for other things clicked on (occupied "tile", etc) or will handle that through
	// the hitpoint thing, not sure yet.


	public Vector2 mousePoint ()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit rayHit;
		Vector2  mousePoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		if (Physics.Raycast (mouseRay, out rayHit)) 
		{
			//Debug.Log ("Mouse hit " + rayHit.transform.name + " at " + rayHit.point);
			Vector2 point = new Vector2 ();
			point.x = Mathf.Round (rayHit.point.x / 10) * 10;
			point.y = (Mathf.Round (rayHit.point.z / 10) * 10) + 5;
			return point;
		}
		Vector2 invalid = new Vector2(-1f, -1f);
		return invalid;
	}

	public List<Ability> deal()
	{
		List<Ability> temp = new List<Ability>();
		corp = GameObject.FindObjectOfType (typeof(Corp)) as Corp;
		deck = corp.deck;
		for (int i = 1; i <= corp.handSize; i++) 
		{
			temp.Add (draw (ref deck));
			//Debug.Log("Added card to hand");
		}
		return temp;
	}

	Ability draw (ref List<Ability> deck)
	{
		Ability initiative = new Ability ();
		initiative = deck [0];
		deck.RemoveAt (0);
		return initiative;
	}
	
}
