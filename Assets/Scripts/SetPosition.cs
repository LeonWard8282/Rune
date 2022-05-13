using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPosition : MonoBehaviour
{/// <summary>
///  Method one in moving a object ot a set target. 
///  Here we set the tranform position of this object to the targets position. 
/// </summary>

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.position = target.position;
    }
}
