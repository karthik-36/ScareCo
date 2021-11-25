
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseZero : MonoBehaviour
{
    public Transform player;

    public Animator anim;

    bool isDeadHere;
    float speed;

    AudioSource m_MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isIdle", true);
        anim.SetBool("isRunning", false);
        anim.SetBool("isAttacking", false);
        anim.SetBool("isDead", false);
        anim.SetBool("isStun", false);
        isDeadHere = false;
        speed = 1.1f;

        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeadHere == false)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = direction.y - 1.5f;
           Debug.Log("direction "  + direction);
            this.transform.rotation =
                Quaternion
                    .Slerp(this.transform.rotation,
                    Quaternion.LookRotation(direction),
                    0.1f);

            anim.SetBool("isIdle", false);
                if (direction.magnitude > 1.1f)
                {
                    this.transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
                    anim.SetBool("isDead", false);
                    anim.SetBool("isStun", false);
                    anim.SetBool("isRunning", true);
                    anim.SetBool("isAttacking", false);
                    anim.SetBool("isIdle", false);
                }
                else
                {
                    anim.SetBool("isDead", false);
                    anim.SetBool("isStun", false);
                    anim.SetBool("isIdle", false);
                    anim.SetBool("isRunning", false);
                    anim.SetBool("isAttacking", true);
                     
                }
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name == "swordCollider")
        {
            isDeadHere = true;
            m_MyAudioSource.Stop();
            speed = 0.0f;
            anim.SetBool("isDead", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isStun", false);
        }
        else if (other.gameObject.name == "bullet1(Clone)")
        {
            isDeadHere = true;
            speed = -0.5f;
            Debug.Log("deamon hit "  +  other.gameObject.name);
            anim.SetBool("isDead", false);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isIdle", false);
            anim.SetBool("isStun", true);
            Invoke("notDead", 0.7f);

      
        }
    }

     private void notDead(){
           isDeadHere = false;
           speed = 1.1f;
    }
}



    

   