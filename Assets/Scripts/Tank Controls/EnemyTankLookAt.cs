using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankLookAt : MonoBehaviour
{
    [SerializeField] Transform playerTransform;



    //v.1
    // void Update()
    // {
    //     Vector2 direction = playerTransform.position - transform.position;
    //     transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);    
    // }


    //v.2

    Vector2 lastRotation;

    void Update()
    {
        Vector2 direction = playerTransform.position - transform.position;
        if (lastRotation != direction)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
            //print("player moving");
        }


        lastRotation = direction;
    }

}
