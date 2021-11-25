using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class redButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject transitionWall;

    public GameObject audioWall;

    public GameObject textHUD;

    void Start()
    {
        transitionWall = GameObject.Find("transitionWall");
    }

    // // Update is called once per frame
    // void Update()
    // {
    // }
    private void OnTriggerEnter(Collider other)
    {
        Debug
            .Log("here hello i am " +
            gameObject.name +
            " and i collided with " +
            other.gameObject.name +
            " tag name is " +
            other.gameObject.tag);

        Debug.Log(other.gameObject.name);

        if (
            other.gameObject.tag == "leftController" ||
            other.gameObject.tag == "rightController"
        )
        {
            transitionWall.GetComponent<Animator>().Play("transitionWall");
            audioWall.GetComponent<AudioSource>().maxDistance = 22.4f;
            TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            textmeshPro
                .SetText("Light the furnace. Reward : Room lights on, Shield");
            Invoke("IdleAnimation", 10.0f);

            //  bigCube[0].GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void IdleAnimation()
    {
        audioWall.GetComponent<AudioSource>().maxDistance = 5.4f;
        transitionWall.GetComponent<Animator>().Play("Idle");
    }
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class activateEventCustom : MonoBehaviour
// {
//     public GameObject[] bigCube;
//     public GameObject[] elePlatform;

//     // Start is called before the first frame update
//     void Start()
//     {
//         bigCube = GameObject.FindGameObjectsWithTag("RedCube1");
//         elePlatform = GameObject.FindGameObjectsWithTag("elePlatform");

//         bigCube[0].GetComponent<MeshRenderer>().enabled = false;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         Debug.Log("here hello i am " + gameObject.name + " and i collided with " + other.gameObject.name + " tag name is " + other.gameObject.tag);

//         Debug.Log(other.gameObject.name);

//         if(other.gameObject.tag == "leftController" || other.gameObject.tag == "rightController"){
//               bigCube[0].GetComponent<MeshRenderer>().enabled = true;
//               elePlatform[0].GetComponent<Animator>().Play("elevator anim");

//         }

//     }
// }
