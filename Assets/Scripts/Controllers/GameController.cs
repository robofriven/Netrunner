/* Will hold scoring information for the player and overall state of the game information (Menu <- Not implemented, Play <- normal game mode, Run <- runner is running)
 */

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    public Text credField;
    public Text tagField;
    public Text linksField;
    public Text scoreField;
    public Text memField;

    public Runner runner;

    public string state;
	string nothingYet;
	public float timeSinceStart;

    private bool runnerReady = false;

	void Awake()
	{
		state = "Play";

	}

	void Update()
	{
		timeSinceStart = Time.time;

        if (!runnerReady)
        {
            runner = FindObjectOfType<Runner>() as Runner;
            if (runner != null)
            {
                runnerReady = true;
            }
        }
        else
        {
            credField.text = runner.credits.ToString();
            tagField.text = runner.tags.ToString();
            linksField.text = runner.links.ToString();
            memField.text = runner.mem.ToString();
            scoreField.text = runner.agendaPts.ToString();
        }

		switch (state)
		{
		case "menu":
			break;
		case "normal":
			break;
		case "run":
			break;
		}
	}

	public void timer(int num = 1)
	{
		Debug.Log("GameController.timer was called and will eventually make the player wait");
	}


}
