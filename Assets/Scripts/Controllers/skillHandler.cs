
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SkillHandler : MonoBehaviour
{
	public Text nameField;
	public Text descriptionField;
	public Text costField;

	public List<Skill> skills;
	public int active;
	public List<Button> buttons;

	public RunnerController runnerController;
	private bool rcReady = false;

	// Use this for initialization
	void Start () 
	{
		active = 0;
//		highlightButton (buttons[active]);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rcReady == false)
		{
			runnerController = GameObject.FindObjectOfType<RunnerController>() as RunnerController;
			if (runnerController != null)
			{
				rcReady = true;
				highlightButton(buttons[active]);
				describe (active);

			}
		}

		if (Input.GetButtonDown ("Jump"))
		{
			// Am I gonna have a jump???
		}
	
		if (Input.GetAxisRaw("Mouse ScrollWheel") > 0f)
		{
			if (runnerController.hand.Count != 0)
			{
				active = (active + 1) % (runnerController.hand.Count);
				highlightButton(buttons[active]);
				describe (active);
			}
		}
		if (Input.GetAxisRaw("Mouse ScrollWheel") < 0f)
		{
			if (runnerController.hand.Count != 0)
            {
				if ((active - 1) < 0)
				{
					active = runnerController.hand.Count - 1;
					highlightButton(buttons[active]);
					describe (active);
				}
				else
				{
					active --;
					highlightButton(buttons[active]);
					describe (active);
				}
			}
		}

		if (Input.GetButtonDown ("QuickBar 1")) 
		{
			active = 0;
			highlightButton(buttons[active]);
			describe (active);
		}



		if (Input.GetButtonDown ("QuickBar 2")) 
		{
			active = 1;
			highlightButton(buttons[active]);
			describe (active);
		}



		if (Input.GetButtonDown ("QuickBar 3")) 
		{
			active = 2;
			highlightButton(buttons[active]);
			describe (active);
		}



		if (Input.GetButtonDown ("QuickBar 4")) 
		{
			active = 3;
			highlightButton(buttons[active]);
			describe (active);
		}
	}



	public void quickBarHandler(int button)
	{
		active = button;
	}

	void highlightButton(Button button)
	{
		var pointer = new PointerEventData(EventSystem.current);
		for (int i = 0; i < buttons.Count; i++)
		{
			if (button == buttons[i])
			{
				ExecuteEvents.Execute (buttons[i].gameObject, pointer, ExecuteEvents.pointerEnterHandler);
			}
			else
			{
				ExecuteEvents.Execute (buttons[i].gameObject, pointer, ExecuteEvents.pointerExitHandler);
			}
			
		}
	}

	void describe(int active)
	{
		// TODO
		// Find GUI object with the Name Field and put name there
		// Find GUI object with Desctiption Field and put description there.

		if (rcReady)
		{
			if (runnerController.hand.Count >= active + 1 && runnerController.hand[active] != null)
			{
				nameField.text = runnerController.hand[active].name;
				descriptionField.text = runnerController.hand[active].description;
				costField.text = (runnerController.hand[active].cost.ToString() + " Cr.");
			}
		}
	}
}
