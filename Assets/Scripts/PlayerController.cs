using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : mainManager  {
    public PlayerInput pi;

    public float CameraRotateSpeed;

    public GameObject model ;

    public Quaternion modelQ1;

    public float walkSpeed;
    public float runSpeed;

    public Animator anim;

    public bool followModel;

    public Vector3 deltaP;

    // Use this for initializat ion
    void Start () {
        pi = GetComponent<PlayerInput>();
        anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {


      
      
      


       
        anim.SetBool("run", pm.sm.isRun);
        anim.SetBool("walk",pm.sm.isWalk );
      

       if (pm .sm .skill1 )
       {
          
           anim.SetTrigger("skill1");

       
       }if (pm .sm .skill2 )
       {
           
            anim.SetTrigger("skill2");
       
       }if (pm .sm .attack  )
       {
           
            anim.SetTrigger("attack");
       
       }
      

    }
    void FixedUpdate()

    {
        if (Input.GetMouseButton(1))
        {
            modelQ1 = model.transform.rotation;

            transform.Rotate(Vector3.up, pi.CameraHor * CameraRotateSpeed * Time.deltaTime);

            model.transform.rotation = modelQ1;

        }
        if (pi.dirvalue > 0.1f)
        {

            model.transform.forward = pi.dirc;


            transform.position += (pm.sm.isRun ? (runSpeed) : (walkSpeed)) * model.transform.forward * pi.dirvalue * Time.deltaTime;
           
        }
        transform.position += deltaP;
        deltaP = Vector3.zero;
    }


    public void  IsfollowModel()
    {
        followModel = true ;
    }public void  NotfollowModel()
    {
        followModel = false;
    }
    public void getRootMotionPosition(object deltaV)
    {
        deltaP =(Vector3 ) deltaV; 
    }
    
}
