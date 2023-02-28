using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StratMain : MonoBehaviour {

    // Use this for initialization
    public void Click()
    {
        SceneManager.LoadScene("MainScene");
        Debug.Log("1");
    }
}
