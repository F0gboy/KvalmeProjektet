using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageScript : MonoBehaviour
{
    public int langNum;
    [SerializeField] public Image cases;
    [SerializeField] public Image pato;
    [SerializeField] public Image kvalme;
    [SerializeField] public Image farm;

    public void English()
    {
        langNum = 1;
    }

    public void Danish()
    {
        langNum = 0;
    }
}
