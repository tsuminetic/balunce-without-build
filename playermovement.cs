using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    bool Canjump=true;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a")){
            rb.AddForce(-600*Time.deltaTime,0,0);
        }
        if (Input.GetKey("d")){
            rb.AddForce(600*Time.deltaTime,0,0);
        }
        if (Input.GetKey("w")){
            rb.AddForce(0,0,600*Time.deltaTime);
        }
        if (Input.GetKey("s")){
            rb.AddForce(0,0,-600*Time.deltaTime);
        }
        if (Input.GetKey("space")){
            if (Canjump==true){
                rb.AddForce(0,200,0);
                Canjump=false;
            }
            
        }
        
    }
    void OnCollisionEnter(Collision other) {
        Canjump=true;
    } 
}
