using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    public TMP_Text textObj;
    public bool rightAnswer = false;
    private ScoreSystem scoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick() 
    { 
        if (rightAnswer) 
        { 
            scoreSystem.ScoreUp();
        }
        else 

        { 
            //placeholder
        }
    }
}
