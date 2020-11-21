using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging;
    private GameObject timer;
    bool hasGameEnded;
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if(TimeLeft.timeLeft <= 0){
            hasGameEnded = true;
        }
        else{
            hasGameEnded = false;
        }

        if(!hasGameEnded){
            if(isDragging) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
             }
        }
    }
}
