using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Question_Manager : MonoBehaviour
{
    public bool lang;
    public List<QuestionAndAnsvers> qNaDK;
    public List<QuestionAndAnsvers> qNaEN;
    private List<QuestionAndAnsvers> qNa;
    public GameObject[] options;
    public int currentIndexQuestion;
    public Text questionPanelText;
    private QuestionAndAnsvers questionAndAnsvers;
    private int correctAnswersCount=0;
    //private int totalCorrectAnswers = 4;


    public Statistic_ManagerPatofisiologi Statistic_ManagerPatofisiologi;
    public GameObject BackGround;
    public Animator Stomach_animator;
    public float typingSpeed=0.004f;
    public Animator Brain_animator;
   

    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        if (lang)
        {
            qNa = qNaDK;
        }
        else
        {
            qNa = qNaEN;
        }
        GenerateQuestion();
        BackGround.SetActive(false);
      
    }
  

    public void Correct()
    {
        Statistic_ManagerPatofisiologi.CorrectAnswers++;

        Brain_animator.SetBool("Trigger", true);
        StartCoroutine(StopAnimation(1));
        Stomach_animator.SetBool("Trigger", true);
        StartCoroutine(StopStomachAnimation(1));

        //correctAnswersCount = 0;
        correctAnswersCount++;
       
        if (correctAnswersCount == qNa[currentIndexQuestion].CorrectAnswer.Count)
        {
            if (qNa.Count > 0)
            {

                qNa.RemoveAt(currentIndexQuestion);
                GenerateQuestion();
            }
        }

    }
    private void SetAnswer()
    {
        for (int i = 0; i < options.Length; i++)
        {
          options[i].GetComponent<PatofysiologiAnswerScript>().isCorrect = false;
          options[i].transform.GetChild(0).GetComponent<Text>().text = qNa[currentIndexQuestion].Answer[i];
          options[i].GetComponent<Image>().color = Color.white;


            if (qNa[currentIndexQuestion].CorrectAnswer.Contains(i + 1))
            {

                options[i].GetComponent<PatofysiologiAnswerScript>().isCorrect = true;
            }

        }
    }
    private void GenerateQuestion()
    {
        if (qNa.Count > 0)
        {
            currentIndexQuestion = Random.Range(0, qNa.Count);
            questionAndAnsvers = qNa[currentIndexQuestion];
            //StartCoroutine(DisplayLine(qNa[currentIndexQuestion].Question));
            questionPanelText.text= qNa[currentIndexQuestion].Question;
            SetAnswer();
            correctAnswersCount = 0;
        }
        else if (qNa.Count == 0)
        {
            BackGround.SetActive(true);
            Statistic_ManagerPatofisiologi.Statistic();
        }
    }
    //private IEnumerator DisplayLine( string line )
    //{
    //    questionPanelText.text = "";

    //    foreach(char letter in line.ToCharArray() )
    //    {
    //        questionPanelText.text += letter;
    //        yield return new WaitForSeconds(typingSpeed);
    //    }
    //}
    private IEnumerator StopAnimation(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        Brain_animator.SetBool("Trigger", false);
       
    }
    private IEnumerator StopStomachAnimation(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        Stomach_animator.SetBool("Trigger", false);

    }
}
