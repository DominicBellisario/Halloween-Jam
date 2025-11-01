using System;
using UnityEngine;

public class SoulLogic : MonoBehaviour
{
    public static event Action SoulShattered;
    public static event Action SoulInElevator;

    [SerializeField] Transform player1;
    [SerializeField] Transform player2;


    private void Update()
    {
        //calculate the position between the two players
        float middlePositionX = player1.position.x + (player2.position.x - player1.position.x) / 2;
        float middlePositionY = player1.position.y + (player2.position.y - player1.position.y) / 2;

        // move the ball to this position
        transform.position = new Vector3(middlePositionX, middlePositionY, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Soul collides with a blocker
        if (collision.gameObject.CompareTag("Blocker"))
        {
            // soul shatters, player loses
            SoulShattered?.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Soul enters the elevator
        if (collision.gameObject.CompareTag("Elevator"))
        {
            // player wins
            SoulInElevator?.Invoke();
        }
    }
}
