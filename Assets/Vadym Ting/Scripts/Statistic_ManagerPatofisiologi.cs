using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Statistic_ManagerPatofisiologi : MonoBehaviour
{
    public bool lang;

    public TMP_Text correctAnswerText;
    public int CorrectAnswers { get;  set; }
    public int WrongAnswer { get;  set; }
    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (correctAnswerText != null)

        {
            if (lang)
            {
                correctAnswerText.text = $"Du har {CorrectAnswers} rigtige svar og {WrongAnswer} forkerte svar ";
            }
            else
            {
                correctAnswerText.text = $"You have {CorrectAnswers} correct and {WrongAnswer} wrong answers ";
            }



        }
    }
    public void Statistic()
    {
        
        
    }
}
