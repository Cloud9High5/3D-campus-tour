using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour {

    public AnimationClip clip;
    public Animator anim;
    public GameObject cam;

    // Use this for initialization
    void Start()
    {

        anim = gameObject.GetComponent<Animator>();
    }
    void Update () {

        AnimatorStateInfo animatorInfo;
        animatorInfo = anim.GetCurrentAnimatorStateInfo(0);

        if(animatorInfo.normalizedTime > 1.0f)
        {
            GameObject.Find("FirstPersonCharacter").GetComponent<Camera>().enabled = true;
            cam.SetActive(false);
        }

    }
}
