using System;
using UnityEngine;

public class Blocker_Collision : MonoBehaviour
{
    public static event Action PlayerFallsInPit;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pit")) 
        {
            Debug.Log("The Thing collides");
            //Kill player and enter loose state
            PlayerFallsInPit.Invoke();
        }
    }
}
