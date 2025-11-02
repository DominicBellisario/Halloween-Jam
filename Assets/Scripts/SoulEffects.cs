using System.Collections;
using UnityEngine;

public class SoulEffects : MonoBehaviour
{
    [SerializeField] float minSize;
    [SerializeField] float maxSize;
    [SerializeField] float speed;

    Vector3 minSizeVector;
    Vector3 maxSizeVector;
    float timer;

    private void Start()
    {
        minSizeVector = new Vector3(minSize, minSize, minSize);
        maxSizeVector = new Vector3(maxSize, maxSize, maxSize);
        timer = 0;

    }

    private void Update()
    {
        timer += Time.deltaTime * speed;
        transform.localScale = Vector3.Lerp(minSizeVector, maxSizeVector, (Mathf.Sin(timer) / 2) + 0.5f);
    }
}
