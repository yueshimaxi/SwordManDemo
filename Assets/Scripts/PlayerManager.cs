using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    // Use this for initialization
    public PlayerController pc;
    public StateManager sm;
    void Awake () {
        pc = GetComponent <PlayerController>();
        pc.pm = this;
        sm = GetComponent<StateManager>();
       sm.pm =this;

    }

    // Update is called once per frame
    void Update () {
		
	}

   
}
