using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
[System.Serializable]
public class AnswerScript : MonoBehaviour
{
    public bool isCorrect= false;
    public Question_Manager question_Manager;
    Image buttonImage ;


    public void Answer()
    {
        if(isCorrect)
        {
            buttonImage = GetComponent<Image>();
            buttonImage.color = Color.green;
            Debug.Log("Correct Answer");
            question_Manager.Correct();
        }
        else
        {
            buttonImage = GetComponent<Image>();
            buttonImage.color = Color.red;
            Debug.Log("Wrong Answer");
        }
    }

}
