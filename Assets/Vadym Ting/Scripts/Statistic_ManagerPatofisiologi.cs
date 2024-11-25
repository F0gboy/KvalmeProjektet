using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Statistic_ManagerPatofisiologi : MonoBehaviour
{
    public Text correctAnswerText;
    public Object[] buttons;
    public int CorrectAnswers { get;  set; }
    public int WrongAnswer { get;  set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Statistic()
    {
        if (correctAnswerText != null)
        correctAnswerText.transform.GetComponent<Text>().text = $"You have {CorrectAnswers} correct and {WrongAnswer} wrong answers ";
    }
}
