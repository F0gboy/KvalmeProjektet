using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuizSystem : MonoBehaviour
{
    // Start is called before the first frame update

    public string[] RightAnswers;
    public string[] WrongAnswers;
    public int Guesses;
    private bool Clicked = false;

    public Button[] Buttons;
    //private Button[] ChosenButtons;
    private static List<Button> ChosenButtons = new List<Button>();


    void Start()
    {
        foreach (var button in Buttons)
        {
            button.onClick.AddListener(delegate { buttonClicked(button); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void buttonClicked(Button currentButton)
    {
        if (ChosenButtons.Count <= Guesses - 1 || ChosenButtons.Count == 5)
        {
            if (!ChosenButtons.Contains(currentButton) && ChosenButtons.Count < 5)
            {
                Debug.Log("Added to List");
                ChosenButtons.Add(currentButton);
                currentButton.image.color = Color.green;

            }
            else
            {
                Debug.Log("Remove from List");

                ChosenButtons.Remove(currentButton);

                currentButton.image.color = Color.white;
            }
        }
    }
}
