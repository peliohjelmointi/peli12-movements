using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankControls : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector2(0f, moveSpeed)*Time.deltaTime); //Space.Self
                                                                    //vs. Space.World
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(new Vector3(0f,0f, rotateSpeed)*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(new Vector3(0f,0f, -rotateSpeed)*Time.deltaTime);
        }
    }
}
