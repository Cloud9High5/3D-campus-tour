using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class getTint : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject enter;

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerRayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 8)
        {
            ActionDisplay.SetActive(true);
        }
        else
        {
            
            ActionDisplay.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            if (TheDistance <= 4)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                enter.SetActive(false);
            }
        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
    }
}
