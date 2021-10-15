using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStopper : MonoBehaviour
{
    public GameObject[] doorstop;
    public GameObject[] doorstop1;
    public GameObject[] doorstop2;
    // Start is called before the first frame update
    void Start()
    {
        doorstop = GameObject.FindGameObjectsWithTag("doorstoppls");
        doorstop1 = GameObject.FindGameObjectsWithTag("doorstoppls1");
        doorstop2 = GameObject.FindGameObjectsWithTag("doorstoppls2");
        // Component[] components = GetComponents(typeof (Component));
        // for (int i = 0; i < components.Length; i++)
        // {
        //     Debug.Log(components[i].name);
        // }

        gameObject.GetComponent<Rigidbody>().freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

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
            gameObject.GetComponent<Rigidbody>().freezeRotation = false;
            CancelInvoke();
            doorstop[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = false;
                    doorstop1[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = false;
                   doorstop2[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (
            other.gameObject.tag == "leftController" ||
            other.gameObject.tag == "rightController"
        )
        {
            if(gameObject.tag == "up"){
                Invoke("SetAngle", 0.8f);  
            }
            else if(gameObject.tag == "downL"){
                Invoke("SetAngle1", 1.3f);  
            }
            else if(gameObject.tag == "downR"){
                Invoke("SetAngle2", 1.3f);  
            }


              
            // doorstop[0]
            //     .GetComponent
            //     <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
            //     >()
            //     .MoveToTargetValue = true;
            // doorstop[1]
            //     .GetComponent
            //     <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
            //     >()
            //     .MoveToTargetValue = true;
            // doorstop[2]
            //     .GetComponent
            //     <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
            //     >()
            //     .MoveToTargetValue = true;
        }
    }


     public void SetAngle()
    {
             doorstop[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = true;
            // doorstop[1]
            //     .GetComponent
            //     <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
            //     >()
            //     .MoveToTargetValue = true;
            // doorstop[2]
            //     .GetComponent
            //     <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
            //     >()
            //     .MoveToTargetValue = true;
    }
       public void SetAngle1()
    {
             doorstop1[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = true;
     
    }
       public void SetAngle2()
    {
             doorstop2[0]
                .GetComponent
                <Tilia.Interactions.Controllables.AngularDriver.AngularDriveFacade
                >()
                .MoveToTargetValue = true;
       
    }
}
