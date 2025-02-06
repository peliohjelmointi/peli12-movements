using System.Collections;
using UnityEngine;

public class ObstaclesAndCollectibles : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("CRASH!");
        StartCoroutine(WaitHalfSecond(collision));        
    }

    IEnumerator WaitHalfSecond(Collision2D collision)
    {
        collision.gameObject.GetComponent<TankControls>().canMove = false;
        yield return new WaitForSeconds(0.5f);
        collision.gameObject.GetComponent<TankControls>().canMove = true;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("Collected!");
    }
}
