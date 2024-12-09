using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreNewScriptKYS : MonoBehaviour
{
    public bool lang;
    private TMP_Text txt;
    private int score = 0;
    [SerializeField] TMP_Text scoreTxt;

    private void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        txt = gameObject.GetComponent<TMP_Text>();

        if (lang)
        {
        txt.text = "Du havde " + scoreTxt.text + " rigtige svar";

        }
        else
        {
            txt.text = "You had " + scoreTxt.text + " correct answers";
        }
    }
}
