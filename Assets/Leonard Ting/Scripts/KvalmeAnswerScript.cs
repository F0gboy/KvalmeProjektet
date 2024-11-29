using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class KvalmeAnswerScript : MonoBehaviour
{

    [SerializeField] private GameObject IDManager;
    [SerializeField] private KvalmeQuestionScript qstScript;
    public bool lang;
    private int ID;
    private List<KvlameAnswerButton1> answerBoxes = new List<KvlameAnswerButton1>();

    private KvlameAnswerButton1 right1 = null;
    private KvlameAnswerButton1 right2 = null;
    private KvlameAnswerButton1 right3 = null;

    
    [SerializeField] private List<GameObject> answerObjects = new List<GameObject>();

    [Header("Question 1")]
    [SerializeField] private List<string> answer1RightDK = new List<string>();
    [SerializeField] private List<string> answer1RightEN = new List<string>();
    [SerializeField] private List<string> answer1WrongDK = new List<string>();
    [SerializeField] private List<string> answer1WrongEN = new List<string>();

    [Header("Question 2")]
    [SerializeField] private List<string> answer2RightDK = new List<string>();
    [SerializeField] private List<string> answer2RightEN = new List<string>();
    [SerializeField] private List<string> answer2WrongDK = new List<string>();
    [SerializeField] private List<string> answer2WrongEN = new List<string>();

    [Header("Question 3")]
    [SerializeField] private List<string> answer3RightDK = new List<string>();
    [SerializeField] private List<string> answer3RightEN = new List<string>();
    [SerializeField] private List<string> answer3WrongDK = new List<string>();
    [SerializeField] private List<string> answer3WrongEN = new List<string>();

    [Header("Question 4")]
    [SerializeField] private List<string> answer4RightDK = new List<string>();
    [SerializeField] private List<string> answer4RightEN = new List<string>();
    [SerializeField] private List<string> answer4WrongDK = new List<string>();
    [SerializeField] private List<string> answer4WrongEN = new List<string>();

    [Header("Question 5")]
    [SerializeField] private List<string> answer5RightDK = new List<string>();
    [SerializeField] private List<string> answer5RightEN = new List<string>();
    [SerializeField] private List<string> answer5WrongDK = new List<string>();
    [SerializeField] private List<string> answer5WrongEN = new List<string>();

    [Header("Question 6")]
    [SerializeField] private List<string> answer6RightDK = new List<string>();
    [SerializeField] private List<string> answer6RightEN = new List<string>();
    [SerializeField] private List<string> answer6WrongDK = new List<string>();
    [SerializeField] private List<string> answer6WrongEN = new List<string>();

    [Header("Question 7")]
    [SerializeField] private List<string> answer7RightDK = new List<string>();
    [SerializeField] private List<string> answer7RightEN = new List<string>();
    [SerializeField] private List<string> answer7WrongDK = new List<string>();
    [SerializeField] private List<string> answer7WrongEN = new List<string>();

    [Header("Question 8")]
    [SerializeField] private List<string> answer8RightDK = new List<string>();
    [SerializeField] private List<string> answer8RightEN = new List<string>();
    [SerializeField] private List<string> answer8WrongDK = new List<string>();
    [SerializeField] private List<string> answer8WrongEN = new List<string>();

    [Header("Question 9")]
    [SerializeField] private List<string> answer9RightDK = new List<string>();
    [SerializeField] private List<string> answer9RightEN = new List<string>();
    [SerializeField] private List<string> answer9WrongDK = new List<string>();
    [SerializeField] private List<string> answer9WrongEN = new List<string>();

  



    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in answerObjects)
        {
            answerBoxes.Add(obj.GetComponent<KvlameAnswerButton1>());
        }
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        IDManager = GameObject.FindGameObjectWithTag("IDManager");
        ID = IDManager.GetComponent<KvalmeIDManagerScript>().id;
        QuestionShift();
    }

    // Update is called once per frame
    void Update()
    {

        int tempInt = 0;
        foreach (KvlameAnswerButton1 item in answerBoxes)
        {
            if (item.clicked)
            {
                tempInt++;
            }
        }

        if (tempInt > 2)
        {
            foreach (KvlameAnswerButton1 item in answerBoxes)
            {
                if (item.clicked)
                {
                    item.UnPlace();
                    item.ButtonClick();
                }
            }
            qstScript.NextQuestion();
            Debug.Log("3 things clicked, switching question");
        }


        if (right1.clicked && right2.clicked && right3.clicked)
        {
            
        }
        if (ID != IDManager.GetComponent<KvalmeIDManagerScript>().id)
        {
            ID = IDManager.GetComponent<KvalmeIDManagerScript>().id;
            QuestionShift();
        }
        
    }



    public void QuestionShift()
    {
        #region Reset-Buttons
        foreach (KvlameAnswerButton1 item in answerBoxes)
        {
            item.rightAnswer = false;
            item.clicked = false;
            try
            {
                item.img.color = Color.white; 
            }
            catch (System.Exception)
            {
                item.UnPlace();
               
            }
        }
        #endregion

        #region Enable-Right
        int temp1 = Random.Range(0, 8);
        int temp2 = Random.Range(0, 8);
        int temp3 = Random.Range(0, 8);
        while (temp2 == temp1 || temp2 == temp3)
        {
            temp2 = Random.Range(0, 8);
        }
        while (temp3 == temp1 || temp2 == temp3)
        {
            temp3 = Random.Range(0, 8);
        }
        //if (ID == 1 || ID == 2)
        //{
        //    temp2 = temp1;
        //    temp3 = temp2;
        //}
       
        answerBoxes[temp1].rightAnswer = true;
        answerBoxes[temp2].rightAnswer = true;
        right1 = answerBoxes[temp1];
        right2 = answerBoxes[temp2];
        right3 = answerBoxes[temp3];
        //if (ID != 4)
        //{
        //answerBoxes[temp3].rightAnswer = true;
        //right3 = answerBoxes[temp3];

        //}
        
        #endregion

        switch (ID)
        {
            case 1:
                if (lang)
                {
                    List<string> tmpRight = answer1RightDK;
                    List<string> tmpWrong = answer1WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer1RightEN;
                    List<string> tmpWrong = answer1WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 2:
                if (lang)
                {
                    List<string> tmpRight = answer2RightDK;
                    List<string> tmpWrong = answer2WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer2RightEN;
                    List<string> tmpWrong = answer2WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 3:
                if (lang)
                {
                    List<string> tmpRight = answer3RightDK;
                    List<string> tmpWrong = answer3WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer3RightEN;
                    List<string> tmpWrong = answer3WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 4:
                if (lang)
                {
                    List<string> tmpRight = answer4RightDK;
                    List<string> tmpWrong = answer4WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer4RightEN;
                    List<string> tmpWrong = answer4WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 5:
                if (lang)
                {
                    List<string> tmpRight = answer5RightDK;
                    List<string> tmpWrong = answer5WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer5RightEN;
                    List<string> tmpWrong = answer5WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 6:
                if (lang)
                {
                    List<string> tmpRight = answer6RightDK;
                    List<string> tmpWrong = answer6WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer6RightEN;
                    List<string> tmpWrong = answer6WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 7:
                if (lang)
                {
                    List<string> tmpRight = answer7RightDK;
                    List<string> tmpWrong = answer7WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer7RightEN;
                    List<string> tmpWrong = answer7WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 8:
                if (lang)
                {
                    List<string> tmpRight = answer8RightDK;
                    List<string> tmpWrong = answer8WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer8RightEN;
                    List<string> tmpWrong = answer8WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            case 9:
                if (lang)
                {
                    List<string> tmpRight = answer9RightDK;
                    List<string> tmpWrong = answer9WrongDK;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                else
                {
                    List<string> tmpRight = answer9RightEN;
                    List<string> tmpWrong = answer9WrongEN;
                    foreach (KvlameAnswerButton1 box in answerBoxes)
                    {
                        if (box.rightAnswer)
                        {
                            int tmpNum = Random.Range(0, tmpRight.Count);
                            box.textObj.text = tmpRight[tmpNum];
                            tmpRight.Remove(tmpRight[tmpNum]);
                        }
                        else
                        {
                            int tmpNum = Random.Range(0, tmpWrong.Count);
                            box.textObj.text = tmpWrong[tmpNum];
                            tmpWrong.Remove(tmpWrong[tmpNum]);
                        }
                    }
                }
                break;

            
            default:
                break;
        }

    }
}
