using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public List<string> RightAnswers = new List<string>();
    public List<string> RightAnswersCopy = new List<string>();
    public List<string> WrongAnswers = new List<string>();
    public List<List<string>> AnswerLists = new List<List<string>>();

    public int Guesses;
    private bool Correct;

    public Button[] Buttons;
    private static List<Button> ChosenButtons = new List<Button>();
    public Button AnswerButton;


    void Start()
    {
        AnswerLists.Add(RightAnswers);
        AnswerLists.Add(WrongAnswers);

        RightAnswersCopy.AddRange(RightAnswers);

        ScatterAnswers();

        foreach (var button in Buttons)
        {
            button.onClick.AddListener(delegate { buttonClicked(button); });
        }

        AnswerButton.onClick.AddListener(delegate { CheckAnswers(); });
    }

    void CheckAnswers()
    {
        if (ChosenButtons.Count > 0 && ChosenButtons.Count == Guesses)
        {
            foreach (var answer in ChosenButtons)
            {
                TextMeshProUGUI TMP = answer.GetComponentInChildren<TextMeshProUGUI>();

                if (RightAnswersCopy.Contains(TMP.text))
                {
                    answer.image.color = Color.green;
                    Correct = true;
                }
                else
                {
                    answer.image.color = Color.red;

                    Correct = false;
                }
            }

            Debug.Log(Correct);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScatterAnswers()
    {
        string tempText;
        foreach (var button in Buttons)
        {
            TextMeshProUGUI TMP = button.GetComponentInChildren<TextMeshProUGUI>();

            int TempInt = Random.Range(0, 2);

            if (RightAnswers.Count == 0)
            {
                TempInt = 0;
            }

            if (WrongAnswers.Count == 0)
            {
                TempInt = 1;
            }

            if (TempInt == 1)
            {
                tempText = RightAnswers[Random.Range(0, RightAnswers.Count)];
                RightAnswers.Remove(tempText);
            }
            else
            {
                tempText = WrongAnswers[Random.Range(0, WrongAnswers.Count)];
                WrongAnswers.Remove(tempText);

            }

            TMP.text = tempText;
        }
    }

    void buttonClicked(Button currentButton)
    {
        if (ChosenButtons.Count <= Guesses - 1 || ChosenButtons.Count == Guesses)
        {
            if (!ChosenButtons.Contains(currentButton) && ChosenButtons.Count < Guesses)
            {
                Debug.Log("Added to List");
                ChosenButtons.Add(currentButton);
                currentButton.image.color = Color.gray;

            }
            else
            {
                Debug.Log("Remove from List");

                ChosenButtons.Remove(currentButton);

                currentButton.image.color = Color.white;
            }
        }
    }
}
