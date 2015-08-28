
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



	void Start () 
	{
		active = 0;
	}
	
	

	void Update () 
	{
		if (rcReady == false)
		{
			runnerController = GameObject.FindObjectOfType<RunnerController>() as RunnerController;
            runner = GameObject.FindObjectOfType<Runner>() as Runner;
			if (runnerController != null && runner != null)
			{
				rcReady = true;
                //print("RCREADY!!! " + runnerController);
				highlightButton(buttons[active]);
				describe (active);

			}
		}



		if (rcReady && runnerController.cursorHidden)
		{

			if (Input.GetButtonDown ("Jump"))
			{
				// Am I gonna have a jump???
                if (rcReady)
                {
                    runner.credits++;
                }
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
                    install(runnerController.hand[active], progNumb, hardNumb, resNumb);
                    runnerController.hand.RemoveAt(active);
                    active = 0;
                    highlightButton(buttons[active]);
                    describe(active);
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

	void describe(int activeSkill)
	{
		// TODO
		// Find GUI object with the Name Field and put name there
		// Find GUI object with Desctiption Field and put description there.

		if (rcReady)
		{
			if (runnerController.hand.Count >= activeSkill + 1 && runnerController.hand[activeSkill] != null)
			{
                //if (activeSkill >= runnerController.hand.Count)
                //{
                //    activeSkill = runnerController.hand.Count - 1;
                //    active = activeSkill;
                //    highlightButton(buttons[active]);
                //}
				nameField.text = runnerController.hand[activeSkill].name;
				descriptionField.text = runnerController.hand[activeSkill].description;
				costField.text = (runnerController.hand[activeSkill].cost.ToString() + " Cr.");
			}
		}
	}



    // Possibly need to add the progNumb value to the parameters so that it will not update as progNumb is updated??
    void install(Skill skill, int numProg, int numHard, int numRes)
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
            if (progNumb < Programs.Count)
            {
                print("You have space for more programs!");
                Programs[numProg].name = skill.name;
                Programs[numProg].transform.GetChild(0).GetComponent<Text>().text = "X";
                Programs[numProg].onClick.AddListener(() => skill.effect());
                skill.onInstall();

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
            if (hardNumb < Hardware.Count)
            {
                print("You have space for more programs!");
                Hardware[numHard].name = skill.name;
                Hardware[numHard].transform.GetChild(0).GetComponent<Text>().text = "X";
                Hardware[numHard].onClick.AddListener(() => skill.effect());
                skill.onInstall();

                hardNumb++;
            }
            else
            {
                // Popup saying it can't be done!!
                Debug.Log("Popup and all that, but you gots no room left!");
            }
        }

        if (skill.type == "Resource" || skill.type == "resource")
        {
            // attach to resources
            if (resNumb < Resources.Count)
            {
                print("You have space for more programs!");
                Resources[numRes].name = skill.name;
                Resources[numRes].transform.GetChild(0).GetComponent<Text>().text = "X";
                Resources[numRes].onClick.AddListener(() => skill.effect());
                skill.onInstall();

                resNumb++;
            }
            else
            {
                // Popup saying it can't be done!!
                Debug.Log("Popup and all that, but you gots no room left!");
            }
        }

        if (skill.type == "Event" || skill.type == "event")
        {
            skill.effect();
        }
    }
}
