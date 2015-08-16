using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hp : MonoBehaviour
{

	public Image meat;
	public Image net;
	public float netDamage;
	public float meatDamage;

	// Use this for initialization
	void Start () {
		netDamage = 1f;
		meatDamage = 1f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		meat.fillAmount = meatDamage;
		net.fillAmount = netDamage;
		//Debug.Log (netDamage);

		if (netDamage > 1f)  {netDamage =  1f;}
		if (netDamage < 0f)  {netDamage =  0f;}
		if (meatDamage > 1f) {meatDamage = 1f;}
		if (meatDamage < 0f) {meatDamage = 0f;}
	}

	public void takeDamage(string type, int damage)
	{
		if (type == "net")
		{
			netDamage = netDamage - (damage/10);
		}
		else if (type == "meat")
		{
			meatDamage = meatDamage - (damage/10);
		}
		else
		{
			Debug.LogError("Invalid damage type");
			throw new System.NotImplementedException();
		}
	}
}
