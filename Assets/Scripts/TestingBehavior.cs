using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Game object will go from pointA to PointB to PointN back to PointA. 
/// Between each transition speed will vary
/// 
/// </summary>
public class TestingBehavior : MonoBehaviour
{


    [SerializeField] float waypointTolerance = 1f;
    int currentWayPointIndex = 0;

    const float waypointGizmoRadius = 1f;

    //public float time;
    public float speed;
    public float t = 1f;

    public void movetowaypoints()
    {
        for(int i = 0; i < transform.childCount; i ++)
        {
            int j = GetNextIndex(i);

            Vector3 a = GetWayPoint(i);
            Vector3 b = GetWayPoint(j);

            transform.position = Vector3.MoveTowards(a, Vector3.Lerp(a, b, t), speed);

        }

    }





    public void OnDrawGizmos()
    {
        for(int i = 0; i < transform.childCount; i ++)
        {
            int j = GetNextIndex(i);
            Gizmos.DrawSphere(GetWayPoint(i), waypointGizmoRadius);
            Gizmos.DrawLine(GetWayPoint(i), GetWayPoint(j)) ;

        }
    }

    

    public int GetNextIndex(int i)
    {
        if(i+1 == transform.childCount)
        {
            return 0;
        }
        return i + 1;

    }

    public Vector3 GetWayPoint(int i)
    {

        return transform.GetChild(i).position;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }






}