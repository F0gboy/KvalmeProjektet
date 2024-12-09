using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
//using static UnityEditor.PlayerSettings;


public class KvalmeQuestionScript : MonoBehaviour
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
        for (int i = 1; i < 10; i++)
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
        if (numCount == 9)
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
                    textObj.text = "Hvorfor optager man en kvalmeanamnese?";
                }
                else
                {
                    textObj.text = "Why is a Nausea anamnesis taken?";
                }
                
                break;
            case 2:
                if (lang)
                {
                    textObj.text = "Hvilke konsekvenser kan det have for patienten, hvis den antiemetiske behandling ikke har været optimal?";
                }
                else
                {
                    textObj.text = "What consequences can it have for the patient if the antiemetic treatment has not been optimal?";
                }
                break;
            case 3:
                if (lang)
                {
                    textObj.text = "Hvornår skal der foretages en kvalmeanamnese?";
                }
                else
                {
                    textObj.text = "When is a Nausea anamnesis taken?";
                }
                break;
            case 4:
                if (lang)
                {
                    textObj.text = "Hvilke risikofaktorer hos patienten har betydning for kvalmeanamnesen?";
                }
                else
                {
                    textObj.text = "Which risk factors in the patient are significant for the nausea anamnesis?";
                }
                break;
            case 5:
                if (lang)
                {
                    textObj.text = "Hvilke informationer er vigtige at indhente i kvalmeanamnesen ved gennembrudskvalme og -opkastning?";
                }
                else
                {
                    textObj.text = "What information is important to gather in the nausea history in cases of breakthrough nausea and vomiting?";
                }
                break;
            case 6:
                if (lang)
                {
                    textObj.text = " Hvis det er mere end 5 dage siden patienten sidst fik medicinsk kræftbehandling hvilke andre årsager for kvalme kan der være?";
                }
                else
                {
                    textObj.text = "If it has been more than 5 days since the patient last received medical cancer treatment, what other causes for nausea can there be?";
                }
                break;
            case 7:
                if (lang)
                {
                    textObj.text = "Hvad kan patienten selv gøre for at lindre kvalme og opkastning?";
                }
                else
                {
                    textObj.text = "What can the patient do to alleviate nausea and vomiting?";
                }
                break;
            case 8:
                if (lang)
                {
                    textObj.text = "Hvilke fysiske symptomer ses ved kvalme og opkastning?";
                }
                else
                {
                    textObj.text = "Which physical symptoms are seen in nausea and vomiting?";
                }
                break;
            case 9:
                if (lang)
                {
                    textObj.text = "Hvilke sygeplejehandlinger er relevante for en patient med kvalme og opkastning?";
                }
                else
                {
                    textObj.text = "What nursing actions are relevant for a patient with nausea and vomiting?";
                }
                break;
          

        }
    }
}
