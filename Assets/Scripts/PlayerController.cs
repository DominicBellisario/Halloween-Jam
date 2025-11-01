using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// units per second
    /// </summary>
    [SerializeField] float maxSpeed;
    [SerializeField] float acceleration;
    [SerializeField] float friction;

    Transform playerTransform;
    // the current vector representing what movement keys are pressed
    Vector3 currentInput;
    // the current speed applied to the player transform each frame
    Vector3 currentSpeed;

    private void Start()
    {
        playerTransform = gameObject.transform;
    }

    /// <summary>
    /// this is called when any of the movement keys are presssed
    /// </summary>
    /// <param name="inputValue"></param>
    private void OnMove(InputValue inputValue)
    {
        // updates the current keys that are pressed.
        // ex: (1, 0) means D is pressed, (-1, -1) means A and S are pressed
        Vector2 playerInput = inputValue.Get<Vector2>();
        currentInput = (Vector3)playerInput;
    }

    private void Update()
    {
        // apply any movement from the movement keys
        currentSpeed += acceleration * Time.deltaTime * currentInput;

        // reduce the speed: barebones friction
        if (currentInput == Vector3.zero) { currentSpeed -= friction * Time.deltaTime * currentSpeed; }

        // player speed cannot go above max speed
        currentSpeed = Vector3.ClampMagnitude(currentSpeed, maxSpeed);

        // update the player position
        playerTransform.position += currentSpeed * Time.deltaTime;
    }
}
