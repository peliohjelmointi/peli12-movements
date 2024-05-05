using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// VECTOR MAGNITUDE & SQRMAGNITUDE
// https://youtu.be/30_spR3cCxw?si=I1HYUnffWleGWZ0u
public class CalculateDistance : MonoBehaviour
{
    [SerializeField] GameObject enemy; //set to pos 3,2
    
    Vector3 offset;
    
    float rangeCheck = 3f;
    
    void Start()
    {
        offset = transform.position - enemy.transform.position;
        print(offset); //-3,-2
        print(offset.magnitude); //3.605551
        
        //same using Distance method
        float preciseLength = Vector2.Distance(transform.position, enemy.transform.position);
        print($"precise length: {preciseLength}");
    }

    void Update(){
        offset = transform.position - enemy.transform.position;
        float sqrLength = offset.sqrMagnitude;
        if(sqrLength <=rangeCheck*rangeCheck)
            print($"Enemy in range of {rangeCheck}");
    }


    

}
