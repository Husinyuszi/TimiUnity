using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField] float destroyTime;
    [SerializeField] float maxDistance;

    Vector3 startPosition;

    void Start()
    {
        Invoke(nameof(DestroySelf), destroyTime);
        startPosition = transform.position;
    }

    void Update()
    {
        if ((startPosition - transform.position).magnitude > maxDistance)
            DestroySelf();
    }

    void DestroySelf() => Destroy(gameObject);
}
