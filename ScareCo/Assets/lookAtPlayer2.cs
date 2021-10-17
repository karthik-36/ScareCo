using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlayer2 : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform player;
    int x;
    void Start()
    {
        Debug.Log("inside univarsal script");
        player = GameObject.Find("HeadAnchor").transform;
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(x < 3){
         transform.LookAt(player);
        }
        x++;
    }
}
