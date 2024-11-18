using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Question_Manager : MonoBehaviour
{
    public List<QuestionAndAnsvers> qNa;
    public GameObject[] options;
    public int currentIndexQuestion;
    public Text questionPanelText;

    // Start is called before the first frame update
    void Start()
    {   
        GenerateQuestion();
    }
    public void Correct()
    {
        qNa.RemoveAt(currentIndexQuestion);
        GenerateQuestion();
    }
    private void SetAnwer()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
          options[i].transform.GetChild(0).GetComponent<Text>().text = qNa[currentIndexQuestion].Answer[i];
            if (qNa[currentIndexQuestion].CorrectAnswer == i+1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }
    private void GenerateQuestion()
    {
        if (qNa.Count > 0)
        {
            currentIndexQuestion = Random.Range(0, qNa.Count);
            questionPanelText.text = qNa[currentIndexQuestion].Question;
            SetAnwer();
        }
        else
        {
            Debug.Log("Out of question");
        }
    }
    
}
