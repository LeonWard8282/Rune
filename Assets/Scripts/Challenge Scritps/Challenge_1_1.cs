using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_1_1 : MonoBehaviour
{

    public GameObject [] waypoints; // am array of waypoints
    int current = 0; // number to see which way point in the array we are going to
    float rotSpeed; // rotates the object that you are movinf... not really neaded
    public float speed; // determines the speed in which we are moving to the waypoint
    public float waypoint_radius = 1;


 

    // Update is called once per frame
    void Update()
    {

        //if(Vector3.Distance(waypoints[current].transform.position, transform.position) < waypoint_radius)
        //{
        //    current++;
        //   // print("This part is being passed");
        //    if(current >= waypoints.Length)
        //    {
        //        current = 0;
        //    }

        //    transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        //    //transform.position = Vector3.Lerp(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
        //}

        current++;
        if(current >= waypoints.Length)
        {
            current = 0;

        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

    
    


}
