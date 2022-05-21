using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [Header("Script Options")]
    [SerializeField] GameObject lastGround;
    [SerializeField] GameObject grounds;
    [Header("Game Options")]
    [SerializeField] float seeSpawnCount = 20;

    private void Awake()
    {
        for (int i = 0; i < seeSpawnCount; i++)
        {
            GroundSpawn();
        }
    }
    public void GroundSpawn()
    {
        Vector3 direction;
        if(Random.Range(0,2)==0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        lastGround = Instantiate(lastGround, lastGround.transform.position + direction, lastGround.transform.rotation,grounds.transform);

    }
}
