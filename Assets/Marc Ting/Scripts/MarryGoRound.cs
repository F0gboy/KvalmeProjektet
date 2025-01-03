using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarryGoRound : MonoBehaviour
{
    [SerializeField]
    Transform rotationCenter;

    [SerializeField] KvlameAnswerButton1 button;

    [SerializeField]
    float rotationRadius = 2f, angularSpeed = 2f;
    
    float angle, posX, posY = 0f;
    private bool isDragging = false;
    private bool isPlaced = false;

    private void Start()
    {
        float random = Random.Range(0, 360);
        angle = random;
        angularSpeed = Random.Range(0.5f, 2.1f);
    }



    void Update()
    {
        if (isPlaced)
        {
            button.clicked = true;
        }
        else
        {
            button.clicked = false;
        }

        if (!isDragging && !isPlaced)
        {
            posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
            posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
            transform.position = new Vector2(posX, posY);
            angle = angle + Time.deltaTime * angularSpeed;

            if (angle >= 360f)
                angle = 0f;
        }
    }

    public void SetDragging(bool dragging)
    {
        isDragging = dragging; 
    }

    public void SetPlaced(bool placed)
    {
        isPlaced = placed;
        angularSpeed = Random.Range(0.5f, 2.1f);
    }
}
