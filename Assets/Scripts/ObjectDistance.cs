using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDistance : MonoBehaviour
{
    public GameObject Blob1;
    public GameObject Blob2;
    public GameObject Blob3;
    public GameObject Blob4;
    public Sprite RedSprite, GreenSprite, YellowSprite;
   
    public float BlobDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BlobDistance = Vector3.Distance(Blob1.transform.position, Blob2.transform.position);
        if(BlobDistance < 5){
            Blob1.GetComponent<SpriteRenderer>().sprite = RedSprite;
            Blob2.GetComponent<SpriteRenderer>().sprite = RedSprite;
        }
        else if(BlobDistance > 5 && BlobDistance < 10){
            Blob1.GetComponent<SpriteRenderer>().sprite = YellowSprite;
            Blob2.GetComponent<SpriteRenderer>().sprite = YellowSprite;
        }
        else{
            Blob1.GetComponent<SpriteRenderer>().sprite = GreenSprite;
            Blob2.GetComponent<SpriteRenderer>().sprite = GreenSprite;
        }
    }
}
