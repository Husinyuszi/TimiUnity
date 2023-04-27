using UnityEngine;
using static UnityEngine.GraphicsBuffer;

 class LookAt : MonoBehaviour
{

    [SerializeField] Transform target;
    [SerializeField] Vector3 targetOffset;

    [SerializeField] bool enableVerticalTurn = true;
    private void Update()
    {
        Vector3 targetPoint = target.position+targetOffset;
        Vector3 selfPoint = transform.position;
        Vector3 dir = targetPoint - selfPoint;

        if (!enableVerticalTurn)
        {
            dir.y = 0;
        }

        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }
    }
}
