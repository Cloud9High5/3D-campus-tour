using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBackToView : MonoBehaviour {

    public GameObject view;
    public GameObject map;
    public GameObject UI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.SetActive(false);
            view.SetActive(true);
            UI.SetActive(true);
        }
    }
}
