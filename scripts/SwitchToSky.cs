using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToSky : MonoBehaviour {

    public GameObject sky;
    public GameObject CountofCoin;
    public GameObject FPS;
    public GameObject Minimap;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sky.SetActive(true);
            CountofCoin.SetActive(false);
            FPS.SetActive(false);
            Minimap.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
