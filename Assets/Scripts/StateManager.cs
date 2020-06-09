using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : mainManager  {
    public bool isRun;
    public bool isWalk;

    public bool skill1;
    public bool skill2;
    public bool attack;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isRun =( pm .pc .pi .dirvalue  > 0.1f) && Input.GetKey(KeyCode.LeftShift);
        isWalk = pm.pc.pi.dirvalue  > 0.1f&& !Input.GetKey(KeyCode.LeftShift);

        skill1 = Input.GetKeyDown(KeyCode.Alpha1);
        skill2 = Input.GetKeyDown(KeyCode.Alpha2);

        attack = Input.GetMouseButtonDown(0);


    }
}
