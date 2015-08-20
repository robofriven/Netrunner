using UnityEngine;
using System.Collections;

public class Asset : CorpObject {

	public string type;
	public string type2;
	public string description;
	public MouseClick mouseClick;
	public Corp corp;
	public GameController gameController;

	void Awake()
	{
		mouseClick = GameObject.FindObjectOfType<MouseClick>() as MouseClick;
		corp = GameObject.FindObjectOfType<Corp>() as Corp;
		gameController = GameObject.FindObjectOfType<GameController>() as GameController;
	}
}
