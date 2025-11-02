using UnityEngine;

public class PlayerEffects : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.linearVelocity.sqrMagnitude > 0.05f)
        {
            // Calculate the angle in degrees
            float angle = Mathf.Atan2(rb.linearVelocity.y, rb.linearVelocity.x) * Mathf.Rad2Deg;

            // Apply rotation around Z axis
            transform.rotation = Quaternion.Euler(0f, 0f, angle + 90);
        }
    }
}
