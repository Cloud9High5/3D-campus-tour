using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberOfCoin : MonoBehaviour
{
    public GameObject CountofCoin;
    public static int NumofCoin = 0;
    //public GameObject EnviroDisplay;
    //public GameObject Sky;
    //public AudioSource RewardSound;

    /*void Start()
    {
        EnviroDisplay.SetActive(false);
        Sky.SetActive(false);
    }*/

    void Update()
    {
        CountofCoin.GetComponent<Text>().text = "" + NumofCoin;
    }
   /* void OnMouseOver()
    {
        if (NumberOfCoin.NumofCoin == 10)
        {
            StartCoroutine(DisplayMessage());

            if (Input.GetKeyDown(KeyCode.I))
            {
                StartCoroutine(ChangeSky());
                
                if (Input.GetKeyDown(KeyCode.I))
                {
                    Sky.SetActive(false);
                }
            }
        }
    }
    void OnMouseExit()
    {
        StopCoroutine(DisplayMessage());
        EnviroDisplay.SetActive(false);
        StopCoroutine(ChangeSky());
    }
    IEnumerator DisplayMessage()
    {
        EnviroDisplay.SetActive(true);
        yield return new WaitForSeconds(2f);
        EnviroDisplay.SetActive(false);
    }
    IEnumerator ChangeSky()
    {
        yield return new WaitForSeconds(0.00000001f);
        Sky.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    */


}
