using Unity.VisualScripting;
using UnityEngine;

public class BallLogic : MonoBehaviour
{
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
}
