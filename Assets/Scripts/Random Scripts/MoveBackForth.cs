using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackForth : MonoBehaviour
{
    [Range(-2, 2)]
    public float speed = 2f;
    public Vector3 pointA = new Vector3(-1, 0, 0);
    public Vector3 pointB = new Vector3(1, 0, 0);

    //public float delta = 1.5f;

    //[Range(-2,2)]
    //public float speed = 2.0f;
    public Vector3 startposition;


    // Start is called before the first frame update
    void Start()
    {
        startposition = transform.position;
    }


    void Update()
    {

        startposition = Vector3.Lerp(pointA, pointB, speed);
        //Vector3 v = startposition;
        //v.x += delta * Mathf.Sin(Time.time * speed);
        //transform.position = v;
    }

}
