using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CanvasGroup))]
public class Popup : MonoBehaviour
{
    public Text textField;
    [Space(10)]
	protected CanvasGroup canvasGroup;
    [Header("Buttons")]
    public Button buttonPrefab;
    public GameObject buttonPanel;
    [SerializeField] private HorizontalLayoutGroup layoutGroup;
    public List<Button> buttons;


    private RandomWord randomWord;

    virtual public void Start()
	{
		canvasGroup = GetComponent<CanvasGroup>();
        randomWord = FindObjectOfType<RandomWord>();

        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;

        //SetButtons();
        textField.text = randomSentence();
    }

    public void SetButtons(string name1 = "OK", string name2 = "Cancel")
    {
        for (int i = 0; i < 2; i++)
        {
            buttons.Add(Instantiate(buttonPrefab));
            buttons[i].transform.SetParent(buttonPanel.transform);
        }

        if (name1 == "OK")
        {
            buttons[0].transform.GetChild(0).GetComponent<Text>().text = word(randomWord.affirmatives);
        }
        buttons[1].transform.GetChild(0).GetComponent<Text>().text = name2;
    }

    public void SetButtons(string name1, string name2, string name3)
    {
        for (int i = 0; i < 3; i++)
        {
            buttons.Add(Instantiate(buttonPrefab));
            buttons[i].transform.SetParent(buttonPanel.transform);
        }

        buttons[0].transform.GetChild(0).GetComponent<Text>().text = name1;
        buttons[1].transform.GetChild(0).GetComponent<Text>().text = name2;
        buttons[2].transform.GetChild(0).GetComponent<Text>().text = name3;
    }

    public void SetButtons(int num, string[] names)
    {
        if (names.Length != num)
        {
            Debug.Log("Setbuttons needs all buttons to have names");
            throw new System.NotImplementedException();
        }

        for (int i = 0; i < names.Length; i++)
        {
            buttons.Add(Instantiate(buttonPrefab));
            buttons[i].transform.SetParent(buttonPanel.transform);
            buttons[i].transform.GetChild(0).GetComponent<Text>().text = names[i];
        }
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
