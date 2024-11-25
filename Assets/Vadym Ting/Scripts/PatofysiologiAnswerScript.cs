using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PatofysiologiAnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public Question_Manager question_Manager;
    Image buttonImage;
    private PatofysiologiHealthSystem patofysiologiHealthSystem;
  
    [SerializeField]
    private Statistic_ManagerPatofisiologi statistic_ManagerPatofisiologi;

    //public int CorrectAnswers { get; private set; }
    //public int WrongAnswer {  get; private set; }

    private void Start()
    {
        patofysiologiHealthSystem = FindObjectOfType<PatofysiologiHealthSystem>();
    
        buttonImage = GetComponent<Image>();
    }

    public void Answer()
    {
        if (isCorrect)
        {
            buttonImage.color = Color.green;
            Debug.Log("Correct Answer");
            question_Manager.Correct();
            

        }
        else
        {
            buttonImage.color = Color.red;
            Debug.Log("Wrong Answer");
            patofysiologiHealthSystem.LossOfLife();
           

        }
    }
}
