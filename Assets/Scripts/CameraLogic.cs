using UnityEngine;

public class CameraLogic : MonoBehaviour
{
    [SerializeField] Transform player1;
    [SerializeField] Transform player2;
    [SerializeField] Transform soul;
    [SerializeField] float minSize;
    [SerializeField] float border;

    Camera cam;
    float startingZPos;

    private void Start()
    {
        cam = GetComponent<Camera>();
        startingZPos = transform.position.z;
    }

    // done in late update so it runs after all physics stuff
    private void LateUpdate()
    {
        // move the camera to be directly over the soul
        transform.position = new Vector3(soul.position.x, soul.position.y, startingZPos);
        
        // grow or srink the camera to keep both players in frame
        float playerDistanceX = Mathf.Abs(player1.position.x - player2.position.x);
        float playerDistanceY = Mathf.Abs(player1.position.y - player2.position.y);
        float largestDistance = Mathf.Max(playerDistanceX, playerDistanceY);
        cam.orthographicSize = Mathf.Max(minSize, (largestDistance / 2) + border);
    }
}
