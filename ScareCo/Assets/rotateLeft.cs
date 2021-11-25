using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rotateLeft : MonoBehaviour
{
   public GameObject textHUD;
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public bool rotateLeft1;
    private GameObject room1;
    private GameObject room2;
    private float left;
    private float toLeft;

    // Start is called before the first frame update
    void Start()
    {


        room1 = GameObject.Find("Room");
        left = 0f;
        toLeft = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(rotateLeft1){
               //transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.Euler(90,90,90) , Time.deltaTime * lerpTime);
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("rotating left");
            if(toLeft != left){
                left++; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(left, 0f, 0f)); 
            }
        }
     
    }


      private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            rotateLeft1 = true;
            toLeft = toLeft + 90f; 
        }

    }

}
