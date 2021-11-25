using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class rotateRight : MonoBehaviour
{
   public GameObject textHUD;
    public Quaternion startQuaternion;
    public float lerpTime = 1;
    public bool rotateRight1;
    private GameObject room1;
    private GameObject room2;
    private float right;
    private float toRight;

    // Start is called before the first frame update
    void Start()
    {


        room1 = GameObject.Find("Room");
        right = 0f;
        toRight = 0f;

    }

    // Update is called once per frame
    void Update()
    {
        if(rotateRight1){
               //transform.rotation = Quaternion.Lerp(transform.rotation , Quaternion.Euler(90,90,90) , Time.deltaTime * lerpTime);
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("rotating right");
            if(toRight != right){
                right--; 
                room1.transform.rotation = Quaternion.Euler(new Vector3(right, 0f, 0f)); 
            }
        }
     
    }


      private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            rotateRight1 = true;
            toRight = toRight - 90f; 
        }

    }

}
