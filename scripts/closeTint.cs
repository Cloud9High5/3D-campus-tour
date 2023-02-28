using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeTint : MonoBehaviour {

    public GameObject tint;
    public GameObject enter;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            tint.SetActive(false);
            enter.SetActive(true);
        }
	}
}
