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
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, speed*Time.deltaTime); // ez az egysor helyettes�ti az el�tte l�v� sorokat, egyszer�bben le�rva. Rezg�s is elmarad. 

        //-----------------------------------------------------

        /*Vector3 dir = targetPoint - selfPoint;
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir); //az objectet abba az ir�nyba ford�tja + r�tket adhatunk neki a felfel� �r�nyt 
        }*/
    }
}
