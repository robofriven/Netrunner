
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class SkillHandler : MonoBehaviour
{
    public GameController gameController;
	public Text nameField;
	public Text descriptionField;
	public Text costField;
    public List<Button> Programs;
    public List<Button> Hardware;
    public List<Button> Resources;

	public List<Skill> skills;
	public int active;
	public List<Button> buttons;

	public RunnerController runnerController;
    public Runner runner;


	private bool rcReady = false;
    private int progNumb = 0;
    private int hardNumb = 0;
    private int resNumb  = 0;

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
            runner = GameObject.FindObjectOfType<Runner>() as Runner;
			if (runnerController != null && runner != null)
			{
				rcReady = true;
                print("RCREADY!!! " + runnerController);
				highlightButton(buttons[active]);
				describe (active);

			}
		}



		if (rcReady && runnerController.cursorHidden)
		{

			if (Input.GetButtonDown ("Jump"))
			{
				// Am I gonna have a jump???
			}



            if (Input.GetButtonDown("Fire1") && runnerController.cursorHidden == true)
			{
				if (rcReady == false)
				{
					return;
				}

                if (runner.credits >= runnerController.hand[active].cost)
                {
                    runner.credits -= runnerController.hand[active].cost;
                    Debug.Log(progNumb + " is progNumb");
                    install(runnerController.hand[active], progNumb);
                    runnerController.hand.RemoveAt(active);
                }
                else
                {
                    // run a popup with 1 arg and name "OK" and text saying something about being too poor
                    print("You can't afford that card right now");
                }
            }



			// These are the quickbar handlers
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



    // Possibly need to add the progNumb value to the parameters so that it will not update as progNumb is updated??
    void install(Skill skill, int num)
    {

        print("Install");

        if (!rcReady)
        {
            Debug.Log("RunnerController not found yet");
            return;
        }

        if (skill.type == "Program" || skill.type == "program")
        {
            //print("it was a program");


            //TODO fix this
            if (Programs.Count > 0)
            {
                print("You have space for more programs!");
                Programs[num].name = skill.name;
                Programs[num].transform.GetChild(0).GetComponent<Text>().text = "X";
                Programs[num].onClick.AddListener(() => test(num));

                progNumb ++;                
            }
            else
            {
                // Popup saying it can't be done!!
                Debug.Log("Popup and all that, but you gots no room left!");
            }
        }

        if (skill.type == "Hardware" || skill.type == "hardware")
        {
            // ATTACH TO hardware
        }

        if (skill.type == "Resource" || skill.type == "resource")
        {
            // attach to resources
        }   
    }

    void test(int num)
    {
        Debug.Log("Holy crap this thing worked!!!");
        Debug.Log("ProgNumb that was passed was " + num);
    }
}
