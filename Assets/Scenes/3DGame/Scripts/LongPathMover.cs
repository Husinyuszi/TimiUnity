using UnityEngine;

 public class LongPathMover : MonoBehaviour
{
    [SerializeField] Vector3[] points;
    [SerializeField] float speed = 2;

    int targetIndex;

     private void Start()
    {
        transform.position = points[0];
        targetIndex = 1;
    }

     void Update()
    {
        Vector3 target = points[targetIndex];
        transform .position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);   

        if(transform.position == target)
        {
            targetIndex++;

            if (targetIndex >= points.Length) // azért ha játék közben ki kerüle egy pont
                targetIndex = 0;
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        foreach (var point in points)
        {
            Gizmos.DrawSphere(point, 0.2f);
        }

        for (int i= 0; i < points.Length; i++) 
        {
            Vector3 p1 = points[i];
            int i2 =(i+1)% points.Length;
            Vector3 p2 = points[i2];
            Gizmos.DrawLine(p1, p2);
        }
    }
}
