using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour {

    public RectTransform textPos;
    public GameObject text;

	// Update is called once per frame
	void Update () {
        //float x = transform.localPosition.x + speed * Time.deltaTime;
        //transform.localPosition = new Vector3(x, 0, 1);
        textPos.transform.Translate(0, 3, 0);
        if(textPos.anchoredPosition.y > 500)
        {
            text.SetActive(false);
        }
    }
}
