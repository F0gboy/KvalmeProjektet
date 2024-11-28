using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class Statistic_ManagerPatofisiologi : MonoBehaviour
{
    public bool lang;

    public Text correctAnswerText;
    public Object[] buttons;
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
        
    }
    public void Statistic()
    {
        if (correctAnswerText != null) 
        
        {
            if (lang)
            {
                correctAnswerText.transform.GetComponent<Text>().text = $"Du har {CorrectAnswers} rigtige svar og {WrongAnswer} forkerte svar ";
            }
            else
            {
                correctAnswerText.transform.GetComponent<Text>().text = $"You have {CorrectAnswers} correct and {WrongAnswer} wrong answers ";
            }



            }
        
    }
}
