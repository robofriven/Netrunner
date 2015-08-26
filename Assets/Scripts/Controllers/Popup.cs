using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Popup : MonoBehaviour
{

	public Button buttonPrefab;
	public List<Button> buttons;
    public GameObject buttonPanel;

	private CanvasGroup canvasGroup;
	[SerializeField] private HorizontalLayoutGroup layoutGroup;
	[SerializeField] private Text textField;

    private RandomWord randomWord;

	void Start()
	{
		canvasGroup = GetComponent<CanvasGroup>();
        randomWord = FindObjectOfType<RandomWord>();

        SetButtons();
        textField.text = randomSentence();

    }

    public void SetButtons(string name1 = "OK", string name2 = "Cancel")
    {
        for (int i = 0; i < 2; i++)
        {
            buttons.Add(Instantiate(buttonPrefab));
            buttons[i].transform.SetParent(buttonPanel.transform);
        }

        Text butt0Text = buttons[0].transform.GetChild(0).GetComponent<Text>();
        Text butt1Text = buttons[1].transform.GetChild(0).GetComponent<Text>();

        if (name1 == "OK")
        {
            buttons[0].transform.GetChild(0).GetComponent<Text>().text = word(randomWord.affirmatives);
        }
        butt1Text.text = name2;
    }

    public void SetButtons(string name1, string name2, string name3)
    {

    }


    private string randomSentence()
    {
        string word1 = randomWord.randomWords[Random.Range(0, randomWord.randomWords.Length)];
        string word2 = randomWord.randomWords[Random.Range(0, randomWord.randomWords.Length)];
        string word3 = randomWord.randomWords[Random.Range(0, randomWord.randomWords.Length)];
        string word4 = randomWord.randomWords[Random.Range(0, randomWord.randomWords.Length)];

        string sentence = word1 + " " + word2 + " " + word3 + " " + word4;
        return sentence;
    }

    private string word(string[] words)
    {
        return words[Random.Range(0, words.Length)];
    }
}
