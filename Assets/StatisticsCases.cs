using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticsCases : MonoBehaviour
{
    public Text text;
    private bool lang;

    public GameObject QuizSystemObject;
    private QuizSystem QuizSystemScript;  // Reference to the script that has the list of GameObjects

    // Start is called before the first frame update
    void Start()
    {
        QuizSystemObject = GameObject.Find("Answers");
        QuizSystemScript = QuizSystemObject.GetComponent<QuizSystem>(); // Getting reference to the script

        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }

        if (lang)
        {
            text.text = "Du har " + QuizSystem.RightAnswersCount + " rigtige svar, og " + QuizSystem.WrongAnswersCount + " forkerte svar med " + QuizSystem.GuessCount + " svar ialt";
        }
        else
        {
            text.text = "You have " + QuizSystem.RightAnswersCount + " right answers, and " + QuizSystem.WrongAnswersCount + " wrong answers with " + QuizSystem.GuessCount + " answers total";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
