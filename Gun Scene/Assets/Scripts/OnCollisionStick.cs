using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionStick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 private void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag=="stick1"){
            // gameObject.AddComponent<FixedJoint>();
            // gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
            //collision.contacts[0];
            collision.gameObject.transform.parent=gameObject.transform;
    }


 }

}
