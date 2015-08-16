/* So far the only thing I know I need here is states (menu, normal, run)
 */

using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	string state;
	string nothingYet;

	void Awake()
	{
		state = "menu";

	}

	void Update()
	{
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


}
