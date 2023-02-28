using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class rainEffect : MonoBehaviour
{

    private Tenkoku.Core.TenkokuModule tenkokuObject;

    private void Start()
    {
        tenkokuObject = (Tenkoku.Core.TenkokuModule)FindObjectOfType(typeof(Tenkoku.Core.TenkokuModule));
    }

    public void RainEffect()
    {
        tenkokuObject.currentHour = Mathf.FloorToInt(8f);
        tenkokuObject.weather_OvercastAmt = 0.163f;
        tenkokuObject.weather_cloudCumulusAmt = 0f;
        tenkokuObject.weather_RainAmt = 0.5f;
        tenkokuObject.weather_SnowAmt = 0f;
        tenkokuObject.setLatitude = Mathf.Floor(23f);
        tenkokuObject.weather_WindAmt = 0.3f;
        tenkokuObject.weather_lightning = 0f;
        tenkokuObject.weather_WindDir = 30;
        tenkokuObject.weather_humidity = 0.5f;
    }
}
