using UnityEngine;

 class Follower : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;

     void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;

        /*
         Vector3 dir = targetPoint - selfPoint;
         dir.Normalize();

         Vector3 velocity = dir * speed;
         transform.position += velocity * Time.deltaTime;*/
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, speed*Time.deltaTime); // ez az egysor helyettesíti az elötte lévõ sorokat, egyszerûbben leírva. Rezgés is elmarad. 

        //-----------------------------------------------------

        /*Vector3 dir = targetPoint - selfPoint;
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir); //az objectet abba az irányba fordítja + rétket adhatunk neki a felfelé írányt 
        }*/
    }
}
