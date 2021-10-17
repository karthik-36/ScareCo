using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropSilver : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator anim;

    void Start()
    {
         anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


       private void OnTriggerEnter(Collider other)
    {
    
        Debug.Log("box hit by " + other.gameObject.name);

        if(other.gameObject.name == "bullet1(Clone)"){
            //    transitionWall.GetComponent<Animator>().Play("transitionWall");
            //    audioWall.GetComponent<AudioSource>().maxDistance = 22.4f;
            //    Invoke("IdleAnimation", 10.0f);
              anim.SetBool("isSilver", true);
            //  bigCube[0].GetComponent<MeshRenderer>().enabled = true;
              


        }

      
    }
}
