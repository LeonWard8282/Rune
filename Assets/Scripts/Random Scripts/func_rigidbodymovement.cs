using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// rb, unity componet that allows you to use unity built in physics engine. 
/// object needs to have rigibody. 
/// you will need to get the direction of the force. 
/// normalize to just get the direction. 
/// multiply by the force. 
/// use add force to apply the force. 
/// make sure you adjust the drag of the rb else velocity increases forever. 
/// </summary>


public class func_rigidbodymovement : MonoBehaviour
{
    public Transform target;
    public Rigidbody rb; //unity component where you can use the physics engine. 
    public float force;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 f = target.position - transform.position;
        f = f.normalized;
        f = f * force;
        rb.AddForce(f);

    }
}
