using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSetting : MonoBehaviour {

    public GameObject setting;

    public void Click()
    {
        setting.SetActive(false);
    }
}
