using Unity.VisualScripting;
using UnityEngine;

public class Moving_BLocker_Script : MonoBehaviour
{
    [SerializeField] private Transform start_point;
    [SerializeField] private Transform end_point;
    [SerializeField] private float speed;
    private bool direction;
    private float movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movement = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!direction)
        {
            movement += Time.deltaTime*speed;
        }
        else
        {
            movement -= Time.deltaTime*speed;
        }
        gameObject.transform.position = Vector3.Lerp(start_point.position, end_point.position, movement);
        if (gameObject.transform.position == end_point.position)
        {
            direction = true;
        }else if (gameObject.transform.position == start_point.position)
        {
            direction = false;
        }
    }

}
