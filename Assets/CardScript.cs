using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    [SerializeField] bool primary;
    [SerializeField] int speed;
    [SerializeField] CardScript otherCard;
    [SerializeField] CardsManager cardsManager;
    [SerializeField] GameObject Answer1;
    [SerializeField] GameObject Answer2;
    public Vector3 target;
    public bool offScreen;
    public int clickCount;



    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > 685) 
        { 
            transform.localPosition = new Vector3(-700, 0, 0); 
            offScreen = true;
            Answer1.SetActive(false);
            Answer2.SetActive(false);
            cardsManager.NewCard();
        }
        
        if (primary == false && offScreen == false)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(700, 0, 0), Time.deltaTime * speed);
        }
        if (primary == true && transform.localPosition.x < 0) 
        { 
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(0, 0, 0), Time.deltaTime * speed);

        }
        
    }

    public void click()
    {
        clickCount++;
        switch (clickCount)
        {
            case 1:
                Answer1.SetActive(true);
                
                break;

            case 2:
                Answer2.SetActive(true);
                break;
            
            case 3:
                ExitScreen();
                clickCount = 0;
                break;
            
            default:
                break;
        }
    }

    public void ExitScreen()
    {
        if (transform.localPosition.x < 15 && transform.localPosition.x > -15)
        {
        primary = false;
        offScreen = false;
        otherCard.primary = true;

        }

    }





}
