// TODO Fix the startup to be a little bit fancier than (the one who
// makes the room is the corp, that's a placeholder.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NetworkManager : MonoBehaviour {

	public Corp corp;
	public Runner runner;
	public GameObject runnerUI;
	public GameObject corpUI;


	// Use this for initialization
	void Start () {
		Connect();
	}

	void Connect()
	{
		PhotonNetwork.ConnectUsingSettings("Negative Candle, never even seen a monkey");
	}

	void OnGUI()
	{
		GUILayout.Label (PhotonNetwork.connectionStateDetailed.ToString ());
	}



	// First it tries to join a random room, if that fails it makes a room
	// If that fails then they both tried making one at same time and it was too late
	// so it tries to join again.
	void OnConnectedToMaster()
	{
		Debug.Log ("JoinLobby");
		PhotonNetwork.JoinRandomRoom ();
	}

	void OnPhotonRandomJoinFailed()
	{
		Debug.Log ("OnPhotonRandomJoinFailed");
		PhotonNetwork.CreateRoom("Netrunner");
	}

	void OnJoinedRoom()
	{
		Debug.Log ("OnJoinedRoom");

		//gameStart ();


		Room room = PhotonNetwork.room;

		if (room.playerCount == 1)
		{
			// Do waiting thing
			Debug.Log ("Only 1 player");
			gameStart ();
		}

		else if (room.playerCount == 2)
		{
			Debug.Log ("Starting Game");
			gameStart();
		}
		else 
		{
			// Do spectator thing
			Debug.LogError ("Too many people!!!");
		}

	}

	void gameStart()
	{
		if (PhotonNetwork.player.ID == 1)
		{
			SpawnCorp();
			return;
		}
		else if (PhotonNetwork.player.ID == 2)
		{
			SpawnRunner ();
			return;
		}
		else
		{
			Debug.LogError ("too many players");
		}
		
	}

	// Spawns the corp player and then turns on his controller and camera
	// TODO Turn on (and make!) the GUI
	void SpawnCorp()
	{
		GameObject corpGO = PhotonNetwork.Instantiate("Corp", corp.transform.position, corp.transform.rotation, 0);
		((MonoBehaviour)corpGO.GetComponent("CorpController")).enabled = true;
		CorpController corpController = corpGO.GetComponent<CorpController>();
		corpGO.transform.FindChild ("MainCamera").gameObject.SetActive(true);
		corpUI.SetActive(true);

	}

	// Spawns the runner player and then turns on the controller camera and other stuff
	// TODO Turn on the GUI
	void SpawnRunner()
	{
		GameObject runnerGO = (GameObject)PhotonNetwork.Instantiate("Runner", runner.transform.position, runner.transform.rotation, 0);
		((MonoBehaviour)runnerGO.GetComponent("RunnerController")).enabled = true;
		((MonoBehaviour)runnerGO.GetComponent("create")).enabled = true;
		runnerGO.transform.FindChild ("MainCamera").gameObject.SetActive(true);
		runnerUI.SetActive(true);

	}

}
