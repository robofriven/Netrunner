using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour 
{
	public delegate void CLICK();
	public delegate void PLACE(Vector2 position);

	public static event CLICK WAITFORCLICK;
	public static event PLACE CLICKRECEIVED;


	public static void waitForClick()
	{
		if(WAITFORCLICK != null)
		{
			WAITFORCLICK();
		}
	}


	public static void clickReceived(Vector2 position)
	{
		if(CLICKRECEIVED != null)
		{
			CLICKRECEIVED(position);
		}
	}

}