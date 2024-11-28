using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnswerCompiler : MonoBehaviour
{
    [SerializeField] private List<AnswerButton> answers;
    [SerializeField] TMP_Text txtObj;
    void Start()
    {
        txtObj.text = "";
        foreach (var answer in answers)
        {
            if (answer.rightAnswer)
            {
                if (txtObj.text == "")
                {
                    txtObj.text = answer.textObj.text;
                }
                else
                {
                    txtObj.text = txtObj.text + ", " + answer.textObj.text;
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
