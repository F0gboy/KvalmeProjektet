using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public bool clicked;
    public TMP_Text textObj;
    public bool rightAnswer = false;
    private ScoreSystem scoreSystem;
    public Image img;
    [SerializeField] private HealthSystem healthManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreSystem>();
        img = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClick() 
    { 
        clicked = true;
        if (rightAnswer) 
        { 
            scoreSystem.ScoreUp();
            img.color = Color.green;

        }
        else 
        {
            img.color = Color.red;
            healthManager.HealthDown();
        }
    }
}
