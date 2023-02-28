using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSky : MonoBehaviour {

    public GameObject CountofCoin;
    public GameObject sky;
    public GameObject FPS;
    public GameObject minimap;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sky.SetActive(false);
            CountofCoin.SetActive(true);
            FPS.SetActive(true);
            minimap.SetActive(true);
        }
    }
}
