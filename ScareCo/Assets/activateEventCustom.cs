using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateEventCustom : MonoBehaviour
{

    public GameObject rainColl;
    public GameObject rainColl1;
    public GameObject rainColl2;
    public GameObject rainColl3;
    public GameObject rainColl4;
    public GameObject topTerrain;
    public GameObject topTerrain1;
    public GameObject topTerrain2;
    public GameObject[] bigCube;
    public GameObject[] elePlatform;
    

    // Start is called before the first frame update
    void Start()
    {
        bigCube = GameObject.FindGameObjectsWithTag("RedCube1");
        elePlatform = GameObject.FindGameObjectsWithTag("elePlatform");

        bigCube[0].GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

 
    private void OnTriggerEnter(Collider other)
    {
        rainColl.active = false;
        rainColl1.active = false;
        rainColl2.active = false;
        rainColl3.active = false;
        rainColl4.active = false;
        topTerrain.active = false;
        topTerrain1.active = false;
        topTerrain2.active = false;
    
        Debug.Log("here hello i am " + gameObject.name + " and i collided with " + other.gameObject.name + " tag name is " + other.gameObject.tag);

        Debug.Log(other.gameObject.name);

        if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
             // bigCube[0].GetComponent<MeshRenderer>().enabled = true;
              elePlatform[0].GetComponent<Animator>().Play("elevator anim");


        }

      
    }
}
