using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{

    public GameObject target; // The first person object to follow
    private Vector3 offset; // The distance
    private bool following = false;     private Rigidbody rigidBody;

    // Start is called before the first frame update
    // To follow an object keeping an offset distance
    // Use this for initialization
    void Start()  { 	
        rigidBody = GetComponent<Rigidbody>();     
    }
    // Update is called once per frame
    void Update()    {         }

    /*
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "FPCTag") {
            print("Xoc amb: " + gameObject.tag);
            Destroy (gameObject);  // Self destruction
       }
    }
    */
    void Follow() { // Initial values when a message is sent to Follow
    	offset = transform.position - target.transform.position;
	     following = true;
    }
    void LateUpdate() { // To move the càmera AFTER the sphere 
           if (following){  
               // To update the position of the camera AFTER the  update of the sphere
	            transform.position = target.transform.position + offset;
            } 
       }

    public int jumpValue = 3;
    void Impuls() {
         rigidBody.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
    }

}
