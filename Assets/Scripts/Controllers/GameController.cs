/* So far the only thing I know I need here is states (menu, normal, run)
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

    string state;
	string nothingYet;
	public float timeSinceStart;

    private bool runnerReady = false;

	void Awake()
	{
		state = "menu";

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
