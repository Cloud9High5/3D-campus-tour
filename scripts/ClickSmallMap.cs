using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClickSmallMap : MonoBehaviour {

    //public GameObject SmallMapAfterOpened;

    public void OpenSmallMap()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(3);
        }

    }
	
	
}
