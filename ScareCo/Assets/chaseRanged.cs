using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseRanged : MonoBehaviour
{
    public Transform player;

    public Transform waypoint;

    public Animator anim;

    bool isDeadHere;

    bool hasReached;

    AudioSource m_MyAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isIdle", true);
        anim.SetBool("isRunning", false);
        anim.SetBool("isAttacking", false);
        anim.SetBool("isDead", false);
        isDeadHere = false;
        hasReached = false;
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeadHere == false)
        {
            Vector3 direction;
              

            if(hasReached == true){
                direction = player.position - this.transform.position;
            }else{
                  direction = waypoint.position - this.transform.position;
            }

        

            direction.y = 0;
            this.transform.rotation =
                Quaternion
                    .Slerp(this.transform.rotation,
                    Quaternion.LookRotation(direction),
                    0.1f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 0.1 && hasReached == false)
            {
                this.transform.Translate(0.0f, 0.0f, 1.0f * Time.deltaTime);
                anim.SetBool("isRunning", true);
                anim.SetBool("isThrowing", false);
                anim.SetBool("isIdle", false);
            }
            else
            {
                hasReached = true;
                anim.SetBool("isIdle", false);
                anim.SetBool("isRunning", false);
                anim.SetBool("isThrowing", true);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "swordCollider")
        {
            isDeadHere = true;
            m_MyAudioSource.Stop();
            anim.SetBool("isDead", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isIdle", false);
        }

        if (other.gameObject.name == "fanFalling")
        {
            isDeadHere = true;
            m_MyAudioSource.Stop();
            anim.SetBool("isDead", true);
            anim.SetBool("isRunning", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isIdle", false);
        }
    }
}
