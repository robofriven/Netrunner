/* So far the only thing I know I need here is states (menu, normal, run)
 */

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	string state;
	string nothingYet;
	public float timeSinceStart;

	void Awake()
	{
		state = "menu";

	}

	void Update()
	{
		timeSinceStart = Time.time;

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
