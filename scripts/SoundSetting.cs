using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSetting : MonoBehaviour {

    public AudioSource ambient;
    public Slider SoundCtrl;
	
	// Update is called once per frame
	public void control () {
        ambient.volume = SoundCtrl.value;
	}
}
