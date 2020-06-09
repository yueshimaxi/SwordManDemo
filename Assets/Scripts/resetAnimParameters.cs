using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetAnimParameters : MonoBehaviour {
    public Animator anim;
    public string[] paras;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void resetRigger()
    {
        for (int i = 0; i <paras . Length; i++)
        {
            anim.ResetTrigger(paras [i]);

        }
    }
    public void resetAttack()
    {
        anim.ResetTrigger("attack");
    }

}
