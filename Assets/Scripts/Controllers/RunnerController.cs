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
	public bool cursorHidden = true;
	private Runner runner;
	public List<Skill> deck;
	public List<Skill> hand;

	public SkillHandler skillHandler;

	// TODO don't hardcode this!
	private int handSize = 5;
	private int handCount = 0;


	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController>();
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		runner = GameObject.FindObjectOfType(typeof(Runner)) as Runner;
		deck = runner.deck;
		hand = new List<Skill>();
		hand = deal(ref deck);
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

		if (cursorHidden)
		{
			if (Input.GetKeyDown (KeyCode.Tab))
			{
				if (hand.Count < handSize)
	            {
	                Skill temp = draw (ref deck);
					hand.Add (temp);
				}
				else
				{
					Debug.Log ("Hand too full... popup and all that");
				}
			}
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
		for (int i = 1; i <= handSize; i++)
		{
			hand.Add (draw(ref deck));
		}
		return hand;
	}
	
	public Skill draw(ref List<Skill> deck)
	{
		if (hand.Count < handSize)
		{
			Skill skill = new Skill();
			skill = deck[0];
			deck.RemoveAt (0);
			handCount++;
			return skill;
		}
		else
		{
			Debug.Log ("hand full");
			return null;
		}
	}
}
