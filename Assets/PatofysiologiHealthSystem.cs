using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatofysiologiHealthSystem : MonoBehaviour
{
    public int life ;
    //private Question_Manager question_Manager;
    public Text Health_board;

     void Start()
    {
        
    UpdateHealthBoard();
    }
    public void LossOfLife()
    {
        if (life > 0)
        {

            life--;
            UpdateHealthBoard();
        }
        else if (life == 0)
        {

            Debug.Log("You don't have enough lifes");
        }
    }
    private void UpdateHealthBoard()
    {
        Health_board.text = life.ToString();
    }

}
