using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    public Transform player;

    public Animator anim;

    bool isDeadHere;

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

        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeadHere == false)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation =
                Quaternion
                    .Slerp(this.transform.rotation,
                    Quaternion.LookRotation(direction),
                    0.1f);

            anim.SetBool("isIdle", false);

            if (player.position.y > 1.9f)
            {
                anim.SetBool("isIdle", true);
                anim.SetBool("isRunning", false);
                anim.SetBool("isAttacking", false);
           
            }
            else
            {
                if (direction.magnitude > 1.5)
                {
                    this.transform.Translate(0.0f, 0.0f, 1.4f * Time.deltaTime);
                    anim.SetBool("isRunning", true);
                    anim.SetBool("isAttacking", false);
                    anim.SetBool("isIdle", false);
          
                }
                else
                {
              
                    anim.SetBool("isIdle", false);
                    anim.SetBool("isRunning", false);
                    anim.SetBool("isAttacking", true);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "swordCollider")
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
