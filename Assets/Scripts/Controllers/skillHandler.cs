
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SkillHandler : MonoBehaviour
{

	public List<Skill> skills;
	public int active;
	public List<Button> buttons;

	// Use this for initialization
	void Start () {
		active = 0;
		skills = new List<Skill>();
		skills.Add(new batteringRam());
		skills.Add (new aesop());
		skills.Add (new diesel());
		skills.Add (new toolbox());
		highlightButton (buttons[active]);
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetButtonDown ("Jump"))
		{
			Debug.Log ("Jump hit!");
			randomDealer deal = new randomDealer();
			deal.deal ("runner");
		}
	
		if (Input.GetAxisRaw("Mouse ScrollWheel") > 0f)
		{
			active = (active + 1) % buttons.Count;
		}
		if (Input.GetAxisRaw("Mouse ScrollWheel") < 0f)
		{
			if ((active - 1) < 0)
			{
				active = buttons.Count - 1;
			}
			else
			{
				active = active - 1;
			}
		}

		if (Input.GetButtonDown ("QuickBar 1")) 
		{
			active = 0;
		}
		if (Input.GetButtonDown ("QuickBar 2")) 
		{
			active = 1;
		}
		if (Input.GetButtonDown ("QuickBar 3")) 
		{
			active = 2;
		}
		if (Input.GetButtonDown ("QuickBar 4")) 
		{
			active = 3;
		}

		highlightButton(buttons[active]);
	
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
}
