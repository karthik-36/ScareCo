using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class objective3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textHUD;
    void Start()
    {
         //   textHUD.GetComponent<TMPro.TextMeshProUGUI>().text = "123";
            //   TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            // textmeshPro.SetText("helllllllllllllllllloooooooooooooooooooooo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro.SetText("find a way to defeat the other monster (hint : silver sword)");
        }

    }
}
