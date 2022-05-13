using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypoints : MonoBehaviour
{
    [SerializeField] float waypointTolerance = 1f;
    int currentWaypointIndex = 0;

    const float waypointGizmoRadius = 1f;
    private void OnDrawGizmos()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            int j = GetNextIndex(i);
            Gizmos.DrawSphere(GetWayPoint(i), waypointGizmoRadius);
            Gizmos.DrawLine(GetWayPoint(i), GetWayPoint(j));
        }

    }

    public int GetNextIndex(int i)
    {
        if (i + 1 == transform.childCount)
        {
            return 0;
        }
        return i + 1;
    }

    public Vector3 GetWayPoint(int i)
    {
        return transform.GetChild(i).position;
    }

    private bool AtWaypoint()
    {
        float distanceToWayPoint = Vector3.Distance(transform.position, GeCurrentWaypoint());
        return distanceToWayPoint < waypointTolerance;

    }

    private Vector3 GeCurrentWaypoint()
    {
        return GetWayPoint(currentWaypointIndex);

    }

    private void CycleWaypoint()
    {
        currentWaypointIndex = GetNextIndex(currentWaypointIndex);

    }
}
