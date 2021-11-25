using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coalTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fire;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "torchTrigger")
        {
            fire.active = true;
            RenderSettings.ambientIntensity = 1.7f;        
        }
    }
}
