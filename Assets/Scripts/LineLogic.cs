using System;
using UnityEngine;

public class LineLogic : MonoBehaviour
{
    public static event Action SoulLineBroke;

    [SerializeField] Transform player1;
    [SerializeField] Transform player2;
    [SerializeField] float maxDistance;

    LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        line.SetPosition(0, player1.position - transform.position);
        line.SetPosition(1, player2.position - transform.position);

        if (Vector3.Distance(player1.position, player2.position) > maxDistance)
        {
            SoulLineBroke.Invoke();
        }
    }
}
