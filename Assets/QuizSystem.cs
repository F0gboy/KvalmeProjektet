using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public bool lang;

    [SerializeField] private List<string> RightAnswersDK = new List<string>();
    [SerializeField] private List<string> RightAnswersEN = new List<string>();

    public static int RightAnswersCount;
    public static int WrongAnswersCount;
    public static int GuessCount;

    public GameObject NextSceneButton;
    public List<string> RightAnswers = new List<string>();
    private List<string> RightAnswersCopy = new List<string>();

    [SerializeField] private List<string> WrongAnswersDK = new List<string>();
    [SerializeField] private List<string> WrongAnswersEN = new List<string>();
    public List<string> WrongAnswers = new List<string>();
    public List<List<string>> AnswerLists = new List<List<string>>();

    public int Guesses;
    private bool Correct;

    public Button[] Buttons;
    private static List<Button> ChosenButtons = new List<Button>();
    public Button AnswerButton;


    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }

        if (lang)
        {
            RightAnswers = RightAnswersDK;
            WrongAnswers = WrongAnswersDK;
        }
        else
        {
            RightAnswers = RightAnswersEN;
            WrongAnswers = WrongAnswersEN;
        }
        
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
        NextSceneButton.SetActive(true);

        GuessCount++;

        if (ChosenButtons.Count > 0 && ChosenButtons.Count == Guesses)
        {
            foreach (var answer in ChosenButtons)
            {
                TextMeshProUGUI TMP = answer.GetComponentInChildren<TextMeshProUGUI>();

                if (RightAnswersCopy.Contains(TMP.text))
                {
                    answer.image.color = Color.green;
                    Correct = true;
                    RightAnswersCount++;
                }
                else
                {
                    answer.image.color = Color.red;

                    Correct = false;

                    WrongAnswersCount++;
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

    public void ResetGameObjects()
    {
        ChosenButtons.Clear();

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
