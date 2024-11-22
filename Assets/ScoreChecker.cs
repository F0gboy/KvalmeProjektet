using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreChecker : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text textObj;
    void Start()
    {
        textObj.text = scoreText.text;
    }

    
}
