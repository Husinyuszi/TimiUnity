using UnityEngine;

[ExecuteAlways]

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    //[SerializeField] Vector3 distanceVector;
    //2[SerializeField] float verticalDistance=10;
    //2[SerializeField] float horizontalDistance=15;
    [SerializeField] float distance = 10;
    public float verticalAngle = 30;
    public float horizontalAngle = 0;

     void LateUpdate()
    {
        FreshCamera ();
    }

     void FreshCamera()
    {
       // transform.position = target.position + target.TransformVector (distanceVector);->karakter forgatást kövesse

        float verticalDistance= distance*Mathf.Sin(verticalAngle*Mathf.Deg2Rad);
        float horizontalDistance = distance * Mathf.Cos(verticalAngle*Mathf.Deg2Rad);

        float xDistance = horizontalDistance * Mathf.Sin(horizontalAngle * Mathf.Deg2Rad);
        float zDistance = verticalDistance * Mathf.Cos(horizontalAngle * Mathf.Deg2Rad);

        Vector3 distanceVector = new Vector3 (xDistance, verticalDistance, horizontalDistance);
        transform.position = target.position+ distanceVector;

        transform.LookAt(target);
    }
}
