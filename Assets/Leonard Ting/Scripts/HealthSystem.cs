using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private TMP_Text txt;
    public int health = 3;
    [SerializeField] GameObject quizParent;
    [SerializeField] GameObject lossParent;

    private void Start()
    {
        txt = gameObject.GetComponent<TMP_Text>();
    }
    public void HealthDown()
    {
        health--;
        txt.text = health.ToString();
        if (health <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        lossParent.SetActive(true);
        quizParent.SetActive(false);
    }
}

