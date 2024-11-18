using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class AnswerScript : MonoBehaviour
{
    public bool isCorrect= false;
    public Question_Manager question_Manager;

    public void Answer()
    {
        if(isCorrect)
        {
            Debug.Log("Correct Answer");
            question_Manager.Correct();
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }

}
