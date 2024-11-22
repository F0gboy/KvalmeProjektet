//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;


//public class Question_Manager : MonoBehaviour
//{
//    public List<QuestionAndAnsvers> qNa;
//    public GameObject[] options;
//    public int currentIndexQuestion;
//    public Text questionPanelText;
//    private QuestionAndAnsvers questionAndAnsvers;
//    private int correctAnswersCount = 0; 
//    private int totalCorrectAnswers = 4;
    
//    // Start is called before the first frame update
//    void Start()
//    {   
//        GenerateQuestion();
//    }
//    public void Correct()
//    {
//        correctAnswersCount++;

//        if (correctAnswersCount == totalCorrectAnswers)
//        {
//            if (qNa.Count > 0)
//            {
//                qNa.RemoveAt(currentIndexQuestion);
//                GenerateQuestion();
//            }
//        }
     

//    }
//    private void SetAnswer()
//    {
//        for (int i = 0; i < options.Length; i++)
//        {
//          options[i].GetComponent<PatofysiologiAnswerScript>().isCorrect = false;
//          options[i].transform.GetChild(0).GetComponent<Text>().text = qNa[currentIndexQuestion].Answer[i];
//          options[i].GetComponent<Image>().color = Color.white;


//            if (qNa[currentIndexQuestion].CorrectAnswer.Contains(i + 1))
//                {
               
//                    options[i].GetComponent<PatofysiologiAnswerScript>().isCorrect = true;
//                }
          
//        }
//    }
//    private void GenerateQuestion()
//    {
//        if (qNa.Count > 0)
//        {
//            currentIndexQuestion = Random.Range(0, qNa.Count);
//            questionPanelText.text = qNa[currentIndexQuestion].Question;
//            SetAnswer();
//            correctAnswersCount = 0;
//        }
//        else
//        {
//            Debug.Log("Out of question");
//        }
//    }
    
//}
