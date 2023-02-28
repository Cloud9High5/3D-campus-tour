using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class snowEffect : MonoBehaviour
{
    private Tenkoku.Core.TenkokuModule tenkokuObject;

    private void Start()
    {
        tenkokuObject = (Tenkoku.Core.TenkokuModule)FindObjectOfType(typeof(Tenkoku.Core.TenkokuModule));
    }

    public void SnowEffect()
    {
        tenkokuObject.currentHour = Mathf.FloorToInt(8f);
        tenkokuObject.setLatitude = Mathf.Floor(23f);
        tenkokuObject.weather_cloudAltoStratusAmt = 0f;
        tenkokuObject.weather_cloudCirrusAmt = 0f;
        tenkokuObject.weather_cloudCumulusAmt = 0.5f;
        tenkokuObject.weather_OvercastAmt = 0f;
        tenkokuObject.weather_SnowAmt = 1f;
        tenkokuObject.weather_RainAmt = 0f;
        tenkokuObject.weather_WindAmt = 0.8f;
        tenkokuObject.weather_WindDir = 90;
        tenkokuObject.weather_humidity = 0.3f;
        tenkokuObject.weather_lightning = 0f;
    }
}
