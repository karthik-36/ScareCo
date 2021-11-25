using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KarthikInput : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textHUD;

    public GameObject menu;

    private int count;

    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

       //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter2;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet2;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force2;

    private GameObject Player1;

    private GameObject[] allWebs;

    private GameObject[] allMainWebs;

    private GameObject[] allWebs2;

    private GameObject[] allMainWebs2;

    private Rigidbody rb;

    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
            // count++;
            // textmeshPro.SetText("shoot web " + count);
            // Player1 = GameObject.Find("CollidableVolume1");
            // rb = Player1.GetComponent<Rigidbody>();
            // rb.velocity = Vector3.zero;

            // //rb.isKinametic = true;
            // //   RigidBody rb = Player1.GetComponent<RigidBody>();
            // // Debug.Log("name " + Player1.name); .velocity = Vector3.zero;
            // // Component[] components = Player1.GetComponents(typeof (Component));
            // // foreach (Component component in components)
            // // {
            // //     Debug.Log(component.ToString());
            // // }
            // //  Player1.Rigidbody.angularVelocity = Vector3.zero;
            // //The Bullet instantiation happens here.
            // GameObject Temporary_Bullet_Handler;
            // Temporary_Bullet_Handler =
            //     Instantiate(Bullet,
            //     Bullet_Emitter.transform.position,
            //     Bullet_Emitter.transform.rotation) as
            //     GameObject;

            // //GameObject.transform.position
            // //  YourObject.Rigidbody.velocity = Vector3.zero;
            // //  YourObject.Rigidbody.angularVelocity = Vector3.zero;
            // allWebs = GameObject.FindGameObjectsWithTag("webs");
            // allMainWebs = GameObject.FindGameObjectsWithTag("mainWeb");
            // for (int i = 1; i < allMainWebs.Length - 1; i++)
            // {
            //     Debug.Log(allMainWebs[i].name + " " + i);
            //     Destroy(allMainWebs[i]);
            // }
            // for (int i = 0; i < allWebs.Length; i++)
            // {
            //     allWebs[i].transform.localScale =
            //         new Vector3(2.534534f, 0.0485903f, 1.324859f);
            // }
            // //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
            // //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
            // // Temporary_Bullet_Handler.transform.Rotate(Vector3.right * 90);

            // // //Retrieve the Rigidbody component from the instantiated Bullet and control it.
            // // Rigidbody Temporary_RigidBody;
            // // Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            // // //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
            // // Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

            // //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
            // // Destroy(Temporary_Bullet_Handler, 5.0f);

            shootWeb();
            shootWebL();
        }
    }

    public void changeSceneZeroGravity()
    {
        menu.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("sceneZeroGravity");
    }

    public void changeSceneMainProject2()
    {
        menu.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("ScareCo17 Final");
        menu.active = false;
        Time.timeScale = 1;
    }

    public void changeSceneUpsideDown()
    {
        menu.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("sceneUpsideDown");
        menu.active = false;
        Time.timeScale = 1;
    }

    public void changeSceneMegaPlay()
    {
        menu.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("scenePlaySet");
        menu.active = false;
        Time.timeScale = 1;
    }

    public void changeSceneGiants()
    {
        menu.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("sceneLandOfGiants");
        menu.active = false;
        Time.timeScale = 1;
    }

    public void activeDeactivateMenu()
    {
        if (menu.active == true)
        {
            menu.active = false;
            Time.timeScale = 1;
        }
        else
        {
            menu.active = true;
            Time.timeScale = 0;
        }
    }

    public void shootWeb()
    {
        // TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
        // count++;
        // textmeshPro.SetText("shoot web " + count);

        //The Bullet instantiation happens here.
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler =
            Instantiate(Bullet,
            Bullet_Emitter.transform.position,
            Bullet_Emitter.transform.rotation) as
            GameObject;

        //GameObject.transform.position
        //  YourObject.Rigidbody.velocity = Vector3.zero;
        //  YourObject.Rigidbody.angularVelocity = Vector3.zero;
       // var rigidbody = this.GetComponent<Rigidbody>();
        Player1 = GameObject.Find("CollidableVolume1");
        rb = Player1.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;

        allWebs = GameObject.FindGameObjectsWithTag("webs");
        allMainWebs = GameObject.FindGameObjectsWithTag("mainWeb");
        for (int i = 1; i < allMainWebs.Length - 1; i++)
        {
            Debug.Log(allMainWebs[i].name + " " + i);
            Destroy(allMainWebs[i]);
        }
        for (int i = 0; i < allWebs.Length; i++)
        {
            allWebs[i].transform.localScale =
                new Vector3(2.534534f, 0.0485903f, 1.324859f);
        }
        //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
        //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
        // Temporary_Bullet_Handler.transform.Rotate(Vector3.right * 90);

        // //Retrieve the Rigidbody component from the instantiated Bullet and control it.
        // Rigidbody Temporary_RigidBody;
        // Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        // //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
        // Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

        //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
        //    Destroy(Temporary_Bullet_Handler, 5.0f);

        //
    }



       public void shootWebL()
    {
        // TextMeshPro textmeshPro = textHUD.GetComponent<TextMeshPro>();
        // count++;
       // textmeshPro.SetText("shoot web " + count);

        //The Bullet instantiation happens here.
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler =
            Instantiate(Bullet2,
            Bullet_Emitter2.transform.position,
            Bullet_Emitter2.transform.rotation) as
            GameObject;

        Player1 = GameObject.Find("CollidableVolume1");
        rb = Player1.GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero;

        allWebs2 = GameObject.FindGameObjectsWithTag("websL");
        allMainWebs2 = GameObject.FindGameObjectsWithTag("mainWebL");
        for (int i = 1; i < allMainWebs2.Length - 1; i++)
        {
            Debug.Log(allMainWebs2[i].name + " " + i);
            Destroy(allMainWebs2[i]);
        }
        for (int i = 0; i < allWebs2.Length; i++)
        {
            allWebs2[i].transform.localScale =
                new Vector3(2.534534f, 0.0485903f, 1.324859f);
        }


        
    }
}
