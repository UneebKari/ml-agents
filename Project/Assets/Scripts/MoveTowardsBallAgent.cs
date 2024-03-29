using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using System.Diagnostics;
public class MoveTowardsBallAgent : Agent
{
    public Transform target;
    //public override void CollectObservations(VectorSensor sensor)
    //{
    //    sensor.AddObservation(transform.position);
    //    sensor.AddObservation(target.position);

    //}


    public override void OnActionReceived(ActionBuffers action)
    {
        UnityEngine.Debug.Log(action.DiscreteActions[0]);
    }
}
