using UnityEngine;

public class TankControls : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 200f;


    void Update()
    {
        // Top-down movement with rotation
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector2(0f, moveSpeed)*Time.deltaTime); 
                                                                    
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0f, -moveSpeed) * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0f,0f, rotateSpeed)*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0f,0f, -rotateSpeed)*Time.deltaTime);
        }
    }
}
