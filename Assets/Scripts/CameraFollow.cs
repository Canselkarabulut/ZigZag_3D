using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform ballLocation;
    Vector3 dif;
    void Start()
    {
        dif = transform.position - ballLocation.position;
    }

    void Update()
    {
        if(BallMoveController._onGround == true)
        transform.position = ballLocation.position + dif;
    }
}
