using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sunnyEffect : MonoBehaviour
{
    private Tenkoku.Core.TenkokuModule tenkokuObject;

    private void Start()
    {
        tenkokuObject = (Tenkoku.Core.TenkokuModule)FindObjectOfType(typeof(Tenkoku.Core.TenkokuModule));
    }

    public void SunnyEffect()
    {
        tenkokuObject.currentHour = Mathf.FloorToInt(12f);
        tenkokuObject.weather_cloudAltoStratusAmt = 0f;
        tenkokuObject.weather_cloudCirrusAmt = 0f;
        tenkokuObject.weather_cloudCumulusAmt = 0f;
        tenkokuObject.weather_OvercastAmt = 0f;
        tenkokuObject.weather_RainAmt = 0f;
        tenkokuObject.setLatitude = Mathf.Floor(23f);
        tenkokuObject.weather_SnowAmt = 0f;
        tenkokuObject.weather_WindAmt = 0f;
        tenkokuObject.weather_WindDir = 30;
        tenkokuObject.weather_humidity = 0f;
        tenkokuObject.weather_lightning = 0f;
    }
}
