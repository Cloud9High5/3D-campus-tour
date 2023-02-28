using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class stormEffect : MonoBehaviour
{

    private Tenkoku.Core.TenkokuModule tenkokuObject;

    private void Start()
    {
        tenkokuObject = (Tenkoku.Core.TenkokuModule)FindObjectOfType(typeof(Tenkoku.Core.TenkokuModule));
    }

    public void StormEffect()
    {
        tenkokuObject.weather_OvercastAmt = 0.535f;
        tenkokuObject.setLatitude = Mathf.Floor(23f);
        tenkokuObject.weather_RainAmt = 1f;
        tenkokuObject.weather_SnowAmt = 0f;
        tenkokuObject.weather_WindAmt = 0.604f;
        tenkokuObject.weather_lightning = 0.696f;
        tenkokuObject.weather_WindDir = 280;
        tenkokuObject.weather_humidity = 1f;
    }
}
