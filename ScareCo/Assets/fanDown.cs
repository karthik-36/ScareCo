using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanDown : MonoBehaviour
{
    static Animator anim;
    public GameObject shooterDestroy;

    bool isFallen;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isFallen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFallen == false)
        {
            transform.Rotate(0, Time.deltaTime * 210.1f, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (
            other.gameObject.name == "metal123" ||
            other.gameObject.name == "metal124"
        )
        {

            Destroy(shooterDestroy);
            anim.SetBool("isFall", true);
            isFallen = true;
        }
    }
}
