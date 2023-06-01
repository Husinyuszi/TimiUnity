using System.Collections.Generic;
using UnityEngine;

public class BallisticPath : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] float startSpeed=5f;
    [SerializeField] Vector3 gravity = new Vector3(0, -9.81f, 0);
    [SerializeField] float duration = 2f;
    [SerializeField] int drawEveryNPoint = 10;

    void OnValidate()
    {
        if(lineRenderer==null)
            lineRenderer= GetComponent<LineRenderer>();
    }

     void Update()
    {
        List<Vector3>point =new List<Vector3>();

        Vector3 position= transform.position;
        Vector3 velocity =transform.up*startSpeed ;

        int index = 0;
        for (float t = 0; t < duration; t += Time.deltaTime) 
        {
            velocity += gravity * Time.fixedDeltaTime;
            position += velocity * Time.fixedDeltaTime;
            
            if(index% drawEveryNPoint==0)
                point.Add(position);
            index++;

        }

        lineRenderer.positionCount= point.Count;
        lineRenderer.SetPositions(point.ToArray());
    }
}
