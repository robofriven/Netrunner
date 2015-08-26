using UnityEngine;
using System.Collections;

public class EventHandler : MonoBehaviour 
{
    // These events are for waiting for and receiving mouselcicks (used for the corp placing firewalls, etc)
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



    // These events will delegate the programs section of the runners GUI
    public delegate void PROGRAM1(int buttNumb);
    public static event PROGRAM1 PROGRAM1ED;

    public static void program1ed(int buttNumb)
    {
        if (PROGRAM1ED != null)
        {
            PROGRAM1ED(buttNumb);
        }
    }

}