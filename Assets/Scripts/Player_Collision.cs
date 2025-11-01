using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action PlayerFallsInPit;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // player falls into a pit
        if (collision.gameObject.CompareTag("Pit")) 
        {
            //Kill player and enter lose state
            PlayerFallsInPit.Invoke();
        }
    }
}
