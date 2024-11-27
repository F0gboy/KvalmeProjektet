using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;


public class QuestionScript : MonoBehaviour
{
    public bool lang;

    [SerializeField] private TMP_Text textObj;
    [SerializeField] private GameObject quizObj;
    [SerializeField] private GameObject winObj;

    public int id = 0;
    private int idLast = 0;
    private int numCount = 1;
    
    [SerializeField] List<int> questionQueue = new List<int>(); 


    private void Start()
    {
        for (int i = 1; i < 14; i++)
        {
            questionQueue.Add(i);
        }
        questionQueue = Shuffle(questionQueue);

        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp != null) 
        {
            if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        }
        id = questionQueue[0];
        
    }

    private List<int> Shuffle(List<int> ts)
    {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i)
        {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
        return ts;
    }

    private void Update()
    {
        if (id != idLast) 
        { 
            idLast = id;
            ChangeQuestion(id);
        }
    }

    public void NextQuestion()
    {
        if (numCount == 13)
        {
            winObj.SetActive(true);
            quizObj.SetActive(false);
        }
        else
        {
        id = questionQueue[numCount];
        numCount++; 

        }
    }

    public void ChangeQuestion(int id)
    {

        switch (id)
        {
            case 1:
                if (lang)
                {
                    textObj.text = "Hvilken medicin kan anvendes mod forventningskvalme?";
                }
                else
                {
                    textObj.text = "What medication can be used for anticipatory nausea?";
                }
                
                break;
            case 2:
                if (lang)
                {
                    textObj.text = "Hvonår skal patienten senest indtage antiemetika inden behandling med medicinsk kræftbehandling";
                }
                else
                {
                    textObj.text = "When should the patient take antiemetics at the latest before treatment with medical cancer therapy?";
                }
                break;
            case 3:
                if (lang)
                {
                    textObj.text = "Hvilke 5 typer af antiemetika findes der?";
                }
                else
                {
                    textObj.text = "What are the 5 types of antiemetics?";
                }
                break;
            case 4:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Ondansetron?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Ondansetron?";
                }
                break;
            case 5:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Palonosetron?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Palonosetron?";
                }
                break;
            case 6:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Aprepritant?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Aprepitant?";
                }
                break;
            case 7:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Netupitant-Palonosetron (NEPA)?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Netupitant - Palonosetron (NEPA)?";
                }
                break;
            case 8:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Olanzapin?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Olanzapine?";
                }
                break;
            case 9:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger opleves ofte ved Prednisolon?";
                }
                else
                {
                    textObj.text = "What side effects are often experienced with Prednisolone?";
                }
                break;
            case 10:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Lorazepam?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Lorazepam?";
                }
                break;
            case 11:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Metopimazin?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Metopimazine?";
                }
                break;
            case 12:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Domperidon?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Domperidone?";
                }
                break;
            case 13:
                if (lang)
                {
                    textObj.text = "Hvilke bivirkninger er hyppigst ved Metoclopramid?";
                }
                else
                {
                    textObj.text = "What side effects are most common with Metoclopramide?";
                }
                break;

        }
    }
}
