using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHands : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject leftHand, rightHand;
    int timer = 0;
    bool spacebarPressed;
    int direction = 0;
    float originalLeftY, originalRightY;
    public static int numberOfPresses = 0;
    
    void Start()
    {
        originalLeftY = leftHand.transform.position.y;
        originalRightY = rightHand.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if( timer > 0){
            timer--;
        }

        if(Input.GetKeyDown(KeyCode.Space) && timer == 0) {
            timer = 32;
            numberOfPresses++;
            leftHand.transform.position = new Vector3(leftHand.transform.position.x, originalLeftY, leftHand.transform.position.z);
            rightHand.transform.position = new Vector3(rightHand.transform.position.x, originalRightY, rightHand.transform.position.z);
         
        }
        if(direction == 0 && timer == 32){
            leftHand.transform.position = new Vector3(leftHand.transform.position.x, leftHand.transform.position.y - 2, leftHand.transform.position.z);
            rightHand.transform.position = new Vector3(rightHand.transform.position.x, rightHand.transform.position.y + 2, rightHand.transform.position.z);
            direction = 1;
        }
        else if(direction == 1 && timer == 32){
            leftHand.transform.position = new Vector3(leftHand.transform.position.x, leftHand.transform.position.y + 4, leftHand.transform.position.z);
            rightHand.transform.position = new Vector3(rightHand.transform.position.x, rightHand.transform.position.y - 4, rightHand.transform.position.z);
            direction = 0;

        }
    }
}
