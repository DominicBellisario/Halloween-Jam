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
    Rigidbody2D rb;
    // the current vector representing what movement keys are pressed
    Vector3 currentInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
        // calculate the force applied to the player this frame
        Vector3 force = acceleration * Time.deltaTime * currentInput;

        // apply the force
        rb.AddForce(force);

        // player speed cannot go above max speed
        rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, maxSpeed);

        // reduce the speed: barebones friction
        if (currentInput == Vector3.zero) { rb.linearVelocity -= friction * Time.deltaTime * rb.linearVelocity; }
    }
}
