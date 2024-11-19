using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    private TMP_Text txt;
    private int score = 0;

    private void Start()
    {
        txt = gameObject.GetComponent<TMP_Text>();
    }
    public void ScoreUp()
    {
        score++;
        txt.text = score.ToString();
    }
}
