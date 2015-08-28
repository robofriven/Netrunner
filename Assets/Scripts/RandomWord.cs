/* Random word is a class that will be full of either words or phrases that it will 
 * put together to form phrases or give messages
 */

using System;
using System.IO;
using UnityEngine;
using System.Collections.Generic;

public class RandomWord: MonoBehaviour
{
    public string[] randomWords;
    public string[] affirmatives;

    public void Awake()
	{
		randomWords = GetWords("Assets/Scripts/words.txt", ' ');    
        affirmatives = GetWords("Assets/Scripts/affirmatives.txt", ',');
	}



	private string[] GetWords(string FileName, char deliniator)
	{
		try
		{
			using (StreamReader reader = new StreamReader(FileName))
			{
				string line = reader.ReadToEnd();
				string[] words = line.Split(deliniator);
				return words;
			}
		}
		catch (Exception except)
		{
			Debug.Log("The file could not be read");
			Debug.Log (except.Message);
            return null;
		}
	}

}
