using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{

    [SerializeField] bool primary;
    [SerializeField] int speed;
    [SerializeField] CardScript otherCard;
    public Vector3 target;
    public bool offScreen;



    void Start()
    {

    }   

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x > 585) 
        { 
            transform.localPosition = new Vector3(-600, 0, 0); 
            offScreen = true;
        }
        
        if (primary == false && offScreen == false)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(600, 0, 0), Time.deltaTime * speed);
        }
        if (primary == true && transform.localPosition.x < 0) 
        { 
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(0, 0, 0), Time.deltaTime * speed);
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
