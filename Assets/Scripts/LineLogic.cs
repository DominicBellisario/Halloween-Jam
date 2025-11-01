using UnityEngine;

public class LineLogic : MonoBehaviour
{
    [SerializeField] Transform player1;
    [SerializeField] Transform player2;

    LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        line.SetPosition(0, player1.position - transform.position);
        line.SetPosition(1, player2.position - transform.position);

    }
}
