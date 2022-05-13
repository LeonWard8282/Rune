using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


/// <summary>
///  This function contains a mix for smooth motion and constant speed motion. This will give you
///  a perfec motion to the target. 
/// </summary>
public class funcLerpMoveToward : MonoBehaviour
{
    public Transform target;
    public float time;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 a = transform.position; 
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a,b,time) , speed);
        
    }

}
