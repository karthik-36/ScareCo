using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchSimulation : MonoBehaviour
{
    // Start is called before the first frame update
    string state;

    public Material Material1;

    //in the editor this is what you would set as the object you wan't to change
    public Material MaterialOriginal;

    public GameObject floor;

    public GameObject Room2;

    public GameObject[] toDisableGame;

    void Start()
    {
        state = "office";
        Debug
            .Log("floor name  " +
            floor.GetComponent<MeshRenderer>().material.name);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().name == "scenePlaySet")
        {
            Debug
                .Log("hit hiT hit " +
                other.gameObject.tag +
                "   " +
                other.gameObject.name);
            if (other.gameObject.name == "redButton")
            {
                gameObject.GetComponent<AudioSource>().maxDistance = 7.4f;
                Debug.Log("hit hiT hit");
                if (state == "office")
                {
                    state = "upsideDown";
                    RenderSettings.ambientIntensity = 0.5f;
                    floor.GetComponent<MeshRenderer>().material = Material1;
                }
                else
                {
                    state = "office";
                    RenderSettings.ambientIntensity = 1.0f;
                    floor.GetComponent<MeshRenderer>().material =
                        MaterialOriginal;
                }

                Room2.active = !Room2.active;

                for (int i = 0; i < toDisableGame.Length; i = i + 1)
                {
                    toDisableGame[i].active = !toDisableGame[i].active;
                }
            }
        }
        else
        {
            Debug
                .Log("hit hiT hit " +
                other.gameObject.tag +
                "   " +
                other.gameObject.name);

            if (other.gameObject.name == "CharacterController")
            {
                gameObject.GetComponent<AudioSource>().maxDistance = 7.4f;
                Debug.Log("hit hiT hit");
                if (state == "office")
                {
                    state = "upsideDown";
                    RenderSettings.ambientIntensity = 0.5f;
                    floor.GetComponent<MeshRenderer>().material = Material1;
                }
                else
                {
                    state = "office";
                    RenderSettings.ambientIntensity = 1.0f;
                    floor.GetComponent<MeshRenderer>().material =
                        MaterialOriginal;
                }

                Room2.active = !Room2.active;

                for (int i = 0; i < toDisableGame.Length; i = i + 1)
                {
                    toDisableGame[i].active = !toDisableGame[i].active;
                }
            }
        }
    }
}
