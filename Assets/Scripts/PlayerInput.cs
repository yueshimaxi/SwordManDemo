using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
   public  float Hori;
   public  float Ver ;
   public  float CameraHor;
    public Vector3   dirc;
    public float dirvalue;


  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         Hori = Input.GetAxis("Horizontal");
         Ver = Input.GetAxis("Vertical");
        CameraHor = Input.GetAxis("Mouse X");
        dirc =  (transform.forward * Ver + transform.right *Hori).normalized; ;
        dirvalue = Mathf.Sqrt(Hori * Hori + Ver * Ver);



    }
}
