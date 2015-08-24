using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RunnerController : MonoBehaviour {

	public float speed = 10f;
	public float sensitivity = 2f;
	public float yConstraint = 60.0f;
	private Vector3 direction = Vector3.zero;
	private CharacterController cc;
	private float lookx;
	private float verticalRotation = 0f;
	[SerializeField] private bool cursorHidden = true;
	Runner runner;
	public List<Skill> deck;
	List<Skill> hand;


	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController>();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		runner = GameObject.FindObjectOfType(typeof(Runner)) as Runner;
		deck = runner.deck;
		hand = deal (ref deck);
		/*
		Debug.Log("The deck has");
		for (int i = 0; i < deck.Count; i++)
		{
			Debug.Log(deck[i].name);
		}
		Debug.Log("And " + deck.Count + " cards");
		*/
	}
	
	// Update is called once per frame
	void Update () 
	{

		// Pressing Escape will toggle the cursor.
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (cursorHidden)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
				cursorHidden = false;

			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
				cursorHidden = true;
			}
		}

		if (Input.GetKeyDown (KeyCode.Tab))
		{
			print("Tab pressed");
			Skill temp = draw (ref deck);
			print ("Drew " + temp);
			hand.Add (temp);
			print ("Hand is " + hand);
		}

		// Horizontal Mouse
		lookx = Input.GetAxis ("Mouse X") * sensitivity;


		// Vertical Mouse
		verticalRotation -= Input.GetAxis ("Mouse Y") * sensitivity;
		verticalRotation = Mathf.Clamp (verticalRotation, -yConstraint, yConstraint);



		direction = transform.localRotation * new Vector3 (Input.GetAxis ("Horizontal"), 0.0f, Input.GetAxis ("Vertical"));
	}
	// Update once every physics cycle
	void FixedUpdate()
	{
		if (cursorHidden)
		{
			cc.SimpleMove (direction * speed);
			transform.Rotate(0f, lookx, 0f);
			Camera.main.transform.localRotation = Quaternion.Euler (verticalRotation, 0f, 0f);
			

		}
	}

	List<Skill> deal(ref List<Skill> deck)
	{
		List<Skill> hand = new List<Skill>();
		for (int i = 1; i <= runner.handSize; i++)
		{
			hand.Add (draw(ref deck));
		}
		return hand;
	}
	
	public Skill draw(ref List<Skill> deck)
	{
		Skill skill = new Skill();
		skill = deck[0];
		deck.RemoveAt (0);
		return skill;
	}
}
