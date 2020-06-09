using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootMotionController : MonoBehaviour
{
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame

    void OnAnimatorMove()
    {
        SendMessageUpwards("getRootMotionPosition",(object) anim.deltaPosition);

    }
}

