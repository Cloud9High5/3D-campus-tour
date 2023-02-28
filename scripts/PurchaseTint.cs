using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseTint : MonoBehaviour
{
    float timer = 4.0f;
    public GameObject showTint;

    void Update()
    { 
        if (NumberOfCoin.NumofCoin == 80)
        {
            showTint.SetActive(true);
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                showTint.SetActive(false);
            }
        }
    }
}