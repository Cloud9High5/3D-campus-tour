using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buySky : MonoBehaviour {

    public GameObject buybutton;
    public GameObject ban;

    // Update is called once per frame
    public void Click()
    {
        if(NumberOfCoin.NumofCoin > 5)
        {
            NumberOfCoin.NumofCoin -= 10;
            ban.SetActive(false);
            buybutton.SetActive(false);
        } 
    }
}
