using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToMap : MonoBehaviour {

    public GameObject view;
    public GameObject map;
    public GameObject UI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.SetActive(true);
            view.SetActive(false);
            UI.SetActive(false);

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
