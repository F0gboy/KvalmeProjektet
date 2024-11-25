using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatofysiologiHealthSystem : MonoBehaviour
{
    public int life=3 ;
    private Question_Manager question_Manager;
    public Text Health_board;
    public GameObject Background;
    public Statistic_ManagerPatofisiologi statistic;
    public Animator animator;
   
     void Start()
    {
        Background.SetActive(false);
        UpdateHealthBoard();
    }
    public void LossOfLife()
    {
        if (life > 0)
        {
            statistic.WrongAnswer++;
            life--;
            animator.SetBool("Triger", true);
            StartCoroutine(StopAnimation(1));
            UpdateHealthBoard();
        }
        if (life<=0)
        {
            Debug.Log("You don't have enough lifes");
            Background.SetActive(true);
            statistic.Statistic();       
        }
    }
    private void UpdateHealthBoard()
    {
        Health_board.text = life.ToString();
    }

    private IEnumerator StopAnimation(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        animator.SetBool("Triger", false);
    }

}
