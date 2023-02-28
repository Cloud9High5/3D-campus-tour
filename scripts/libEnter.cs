using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class libEnter : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject ExtraCursor;

	// Update is called once per frame
	void Update () {
        TheDistance = PlayerRayCast.DistanceFromTarget;
	}

    void OnMouseOver()
    {
        if(TheDistance <= 8)
        {
            ActionText.GetComponent<Text>().text = "Welcome to the library!";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
            ExtraCursor.SetActive(true);
        }
        else
        {
            ActionText.GetComponent<Text>().text = "";
            ActionDisplay.SetActive(false);
            ActionText.SetActive(false);
            ExtraCursor.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if(TheDistance <= 8)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                SceneManager.LoadScene("VRScene");
            }
        }
    }
    void OnMouseExit()
    {
        ActionText.GetComponent<Text>().text = "";
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
        ExtraCursor.SetActive(false);
    }
}
