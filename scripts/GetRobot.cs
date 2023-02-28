using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetRobot : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject robot;
    //public GameObject robotModel;

    // Update is called once per frame
    void Update () {
        TheDistance = PlayerRayCast.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {          
            ActionDisplay.SetActive(true);
        }
        else
        {          
            ActionDisplay.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                robot.SetActive(true);
                //robotModel.SetActive(false);
            }
        }
    }
    void OnMouseExit()
    {
        ActionDisplay.SetActive(false);
    }
}
