using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class IcebreakerPopup : Popup {

    [Header("Pay Amounts")]
    public Text textPrefab;
    public Slider sliderPrefab;
    public GameObject amountPanel;
    [SerializeField] private HorizontalLayoutGroup amountLayout;


    public List<Slider> amounts;
    public List<Text> texts;


    public override void Start()
    {
        base.Start();
        var texts = new List<Text>();

        //List<string> names = new List<string>();
        //names.Add("+ Str");
        //names.Add("Short is good");
        //names.Add("Break that shit!");


        //SetAmounts(3, names);
    }

    void Update()
    {
        if (texts.Count != 0)
        {
            for (int i = 0; i < texts.Count; i++)
            {
                texts[i].text = amounts[i].value.ToString();
            }
        }
    }

    public void SetAmounts(int numberOfSliders, List<string> names)
    {
        
        canvasGroup.alpha = 1;

        if (names.Count != numberOfSliders)
        {
            Debug.Log("names.Count must equal numberofSliders!");
            throw new MissingReferenceException();
        }


        if (numberOfSliders > 3)
        {
            Debug.Log("Too many sliders!");
            throw new MissingReferenceException();
                
        }



        for (int i = 0; i < numberOfSliders; i++)
        {
            texts.Add(Instantiate(textPrefab));
            texts[i].transform.SetParent(amountPanel.transform);

            amounts.Add(Instantiate(sliderPrefab));
            amounts[i].transform.SetParent(amountPanel.transform);

            buttons.Add(Instantiate(buttonPrefab));
            buttons[i].transform.SetParent(buttonPanel.transform);
            buttons[i].transform.GetChild(0).GetComponent<Text>().text = names[i];
            //buttons[i].onClick.AddListener(() => test());
        }
    }

    void test()
    {
        Debug.Log("This worked");
    }
}

