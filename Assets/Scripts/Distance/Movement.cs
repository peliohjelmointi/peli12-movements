using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed;
    float xSpeed, ySpeed;
    Vector2 moveDirection;

    Rigidbody2D rb;

    void Awake()
    {
        //GetComponentit lähtökohtaisesti aina Awakeen, ja Startiin niihin sijoitettujen muuttujien käsittely!
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Yleinen tapa kutsua funktioita Updatessa sen sijaan, että koodi olisi suoraan Updatessa, helpottaa luettavuutta
        //Updatessa otetaan pelaajan komennot, mutta itse liikkuminen tapahtuu FixedUpdatessa
        GetInput();
        
    }

    void FixedUpdate()
    {
        MoveRigidBody(); //FixedUpdatessa, Koska pelaajaa liikutetaan rigidbodyllä
    }

    void GetInput()
    {
        //xSpeed = Input.GetAxisRaw("Horizontal"); //GetAxis -1 = vasemmalle, 1 oikealle, 0 paikallaan, joko 0 tai (-)1
        xSpeed = Input.GetAxis("Horizontal"); //GetAxis -1 = vasemmalle, 1 oikealle, 0 paikallaan, kiihtyy nollasta
        ySpeed = Input.GetAxis("Vertical");
        moveDirection = new Vector2(xSpeed, ySpeed);
        
        // normalisoidaan vektori, jotta pelaaja ei liikkuisi viistoihin nopeammin:

        moveDirection = moveDirection.normalized;
        //tai
        //moveDirection.Normalize();
                                

    }

    void MoveRigidBody()
    {
        rb.velocity = moveDirection * moveSpeed; 
    }
}
