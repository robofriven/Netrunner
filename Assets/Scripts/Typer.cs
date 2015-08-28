using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Typer : MonoBehaviour {
	
	public float letterPause = 0.01f;
	public AudioClip typeSound1;
	public AudioClip typeSound2;
	
	string message;
	Text textField;
	
	// Use this for initialization
	void Start () 
	{
		textField = GetComponent<Text>();
		message = textField.text;
		textField.text = "";
		StartCoroutine(TypeText ());
	}
	
	IEnumerator TypeText () 
	{
		foreach (char letter in message.ToCharArray()) 
		{
			textField.text += letter;
			if (typeSound1 && typeSound2)
				//SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
			yield return 0;
			yield return new WaitForSeconds (letterPause);
		}
	}

	IEnumerator AppendText(string message)
	{
		foreach (char letter in message.ToCharArray()) 
		{
			textField.text += letter;
			if (typeSound1 && typeSound2)
				//SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
				yield return 0;
			yield return new WaitForSeconds (letterPause);
		}
	}
}