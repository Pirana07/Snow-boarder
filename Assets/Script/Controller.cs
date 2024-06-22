using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Controller : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float Amout = 1f;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float NormSpeed = 20f;
    bool canMove = true;
    
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }
  public void Disable(){
      canMove = false;
  } 
    // Update is called once per frame
    void Update()
    {
      if(canMove){
      RotatePlayer();
      ResponBoost();
      }
      

      void ResponBoost(){
       if(Input.GetKey(KeyCode.Space)){
        surfaceEffector2D.speed = boostSpeed;
       }else{
        surfaceEffector2D.speed = NormSpeed;
       }
      }
       
       void RotatePlayer(){
       if(Input.GetKey(KeyCode.LeftArrow)){
        rb.AddTorque(Amout);
       }
       else if(Input.GetKey(KeyCode.RightArrow)){
        rb.AddTorque(-Amout);
       }
    }

    }
   
}
