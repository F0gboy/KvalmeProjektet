using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonLanguageScript : MonoBehaviour
{
    public bool lang;
    [SerializeField] private TMP_Text textObj;
    [SerializeField] string denText = "";
    [SerializeField] string engText = "";


    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        if (lang)
        {
            textObj.text = denText;
        }
        else
        {
            textObj.text = engText;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
