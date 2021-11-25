using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scaleWeb : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private GameObject textHUD;
    private bool stop = false;
    void Start()
    {
        textHUD = GameObject.Find("textHUD");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.localScale.x);
        // Debug.Log(transform.position.x);

        if(stop == false){
         transform.localScale = new Vector3(transform.localScale.x + (Time.deltaTime * 55.8f), transform.localScale.y, transform.localScale.z);
        }
        // transform.localPosition.x = transform.localPosition.x + (Time.deltaTime * speed);
    }

    public void OnTriggerEnter(Collider other){
        Debug.Log("hit " + other.name);
        if(other.name != "ExampleAvatar" && other.name != "web2 (1)" && other.name != "web2" && other.name != "HeadAnchor" && other.name == "CharactorController"){
            stop = true;
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("hit " + other.name);
        }
    }
}
