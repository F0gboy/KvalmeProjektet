using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    [SerializeField]
    private Canvas canvas;

    private MarryGoRound marryGoRound;
    private Transform originalParent;
    private bool isPlaced = false;

    private void Awake()
    {
        marryGoRound = GetComponent<MarryGoRound>();
        originalParent = transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (marryGoRound != null)
        {
            marryGoRound.SetDragging(true); 
        }

        marryGoRound.SetPlaced(false);
        isPlaced = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        PointerEventData pointerData = (PointerEventData)eventData;

        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);

        transform.position = canvas.transform.TransformPoint(position);
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        if (marryGoRound != null)
        {
            marryGoRound.SetDragging(false); 
        }

        CheckPlacement(eventData);
    }

    private void CheckPlacement(PointerEventData eventData)
    {
        
        List<RaycastResult> raycastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResults);

        foreach (RaycastResult result in raycastResults)
        {
            if (result.gameObject.CompareTag("PlacementPanel")) 
            {
                transform.SetParent(result.gameObject.transform); 
                transform.position = result.gameObject.transform.position;
                marryGoRound.SetPlaced(true);
                isPlaced = true;
                return;
            }
        }

        foreach (RaycastResult result in raycastResults)
        {
            Debug.Log("Raycast hit: " + result.gameObject.name);
        }

        if (!isPlaced)
        {
            transform.SetParent(originalParent);
            transform.localPosition = Vector3.zero;
        }
    }
}
