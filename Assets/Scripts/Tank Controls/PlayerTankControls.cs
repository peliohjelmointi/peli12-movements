using UnityEngine;

public class TankControls : MonoBehaviour
{
    [SerializeField]float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 200f;

    bool isReversed;

    Vector2 movement;
    Rigidbody2D rb;
    public bool canMove;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Top-down movement with rotation
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
            if (canMove)
            {
                transform.Translate(new Vector2(0f, moveSpeed) * Time.deltaTime);
                //movement = new Vector2(0f, Input.GetAxis("Vertical")).normalized;
                isReversed = false;
            }
            
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (canMove)
            {
                transform.Translate(new Vector2(0f, -moveSpeed) * Time.deltaTime);
                isReversed = true;
            }
            

        }
        //else
        //{
        //    movement = Vector2.zero;
        //}


        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            if(!isReversed)
                transform.Rotate(new Vector3(0f,0f, rotateSpeed)*Time.deltaTime);
            else
            {
                transform.Rotate(new Vector3(0f, 0f, -rotateSpeed) * Time.deltaTime);
            }
            //transform.Translate(new Vector2(-moveSpeed, 0f) * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
            if (!isReversed)
                transform.Rotate(new Vector3(0f, 0f, -rotateSpeed) * Time.deltaTime);
            else
            {
                transform.Rotate(new Vector3(0f, 0f, rotateSpeed) * Time.deltaTime);
            }
        }
      
    }

    //private void FixedUpdate()
    //{
    //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    //}
}
