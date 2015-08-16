// TODO Add a  projector to the Update
// TODO Check to see if there is something there already
// TODO Force the corp to only have set options of where to put things.
// TODO screen popup for info

// TODO Need to fix what I broke trying ot get the projector to work

using UnityEngine;
using System.Collections;

public class MouseClick : MonoBehaviour 
{
	//private Vector2 mousePosition;
	//private Vector3 projectorPosition;
	private Vector2 clicked = new Vector2(-2, -2);

	public  GameObject projector;

	
	void Awake () 
	{
		this.enabled = false;
		EventHandler.WAITFORCLICK += called;
	}


	public void called()
	{
		this.enabled = true;
		projector.SetActive (true);
	}


	void OnEnable()
	{
		//TODO Make a screen tooltip or popup to say this part.
		Debug.Log ("Click where to place your firewall... will eventually be a popup or something");
	}


	void OnDisable()
	{
		//clicked = new Vector2(-2 , -2);
		//projector.SetActive(false);
	}


	void OnDestroy()
	{
		EventHandler.WAITFORCLICK -= called;
	}
	

	void Update () 
	{
		Debug.Log (mousePoint());

		if (Input.GetButtonDown ("Fire1")) 
		{			
			clicked = mousePoint();
			Debug.Log ("Clicked = " + clicked);
			mouseClick();
		}	
	}

	void FixedUpdate()
	{
		//mousePosition = mousePoint();
		
		//projectorPosition = new Vector3(mousePosition.x, 6, mousePosition.y);


		//Debug.Log (string.Format ("Projector should be at {0}", projectorPosition));
		//projector.transform.position = projectorPosition;

	}


	public void mouseClick()
	{	
		if (clicked.x == -2f && clicked.y == -2f)
		{
			Debug.LogError ("Mouseclick event triggered before last one resolved)");
			throw new System.NotImplementedException();
		}

		else
		{
			//Debug.Log(string.Format ("You will place it at {0}", clicked));
			EventHandler.clickReceived(clicked);
			this.enabled = false;
		}
	}


	public Vector2 mousePoint()
	{
		Ray mouseRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		
		RaycastHit rayHit;
		// TODO maybe used to determine if on HUD?? 
		// Vector2  mousePoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
		if (Physics.Raycast (mouseRay, out rayHit)) 
		{
			//Debug.Log ("Mouse hit " + rayHit.transform.name + " at " + rayHit.point);
			Vector2 point = new Vector2 ();
			//point.x = Mathf.Round (rayHit.point.x / 10) * 10;
			//point.y = (Mathf.Round (rayHit.point.z / 10) * 10) + 5;
			return point;
		}
		// Checks to see if the vector is on the playing surface, returns (-1,-1) if not
		Vector2 invalid = new Vector2(-1f, -1f);
		return invalid;
	}
}
