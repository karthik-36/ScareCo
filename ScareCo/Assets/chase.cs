using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{

    public Transform player; 
    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
           anim.SetBool("isIdle" , true);
            anim.SetBool("isRunning" , false);
            anim.SetBool("isAttacking" , false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - this.transform.position;
        direction.y = 0; 
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction) , 0.1f);

        anim.SetBool("isIdle" , false);
        if(direction.magnitude > 1.5 ){
            this.transform.Translate(0.0f,0.0f, 2.133f * Time.deltaTime);
            anim.SetBool("isRunning" , true);
            anim.SetBool("isAttacking" , false);
        }else{
            anim.SetBool("isRunning" , false);
            anim.SetBool("isAttacking" , true);
        }
    }
}
