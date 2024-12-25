using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HelpScript : MonoBehaviour
{
    public bool lang;
    [SerializeField] GameObject Dansk;
    [SerializeField] GameObject Engelsk;
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Language");
        if (temp.GetComponent<LanguageScript>().langNum == 0) { lang = true; }
        
    }

    public void click()
    {
        if (lang)
        {
            Dansk.SetActive(true);
        }
        else
        {
            Engelsk.SetActive(true);
        }
    }
}
