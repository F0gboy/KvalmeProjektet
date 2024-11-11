using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageScript : MonoBehaviour
{
    public int langNum;
    public void English()
    {
        langNum = 1;
    }

    public void Danish()
    {
        langNum = 0;
    }
}
