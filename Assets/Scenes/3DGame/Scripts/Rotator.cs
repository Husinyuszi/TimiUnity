using UnityEngine;

 class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;
    [SerializeField] Vector3 axis = Vector3.up; //osztály változó

     void Update()
    {
        //Vector3 axis=Vector3.up; 
        transform.Rotate(axis /*=tengely*/, angularSpeed * Time.deltaTime, space) ;
    }
     void OnDrawGizmos()
    {
        if(space==Space.Self) 
        {
            Gizmos.matrix = transform.localToWorldMatrix; //csak a loklis terében rajzolja
        }
        
        Vector3 center=space==Space.Self ? Vector3.zero : transform.position;

        //Vector3 center = Vector3.zero;//transform.position;
        Vector3 a= center + axis.normalized;
        Vector3 b= center - axis.normalized;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(a,b);

        Gizmos.matrix = Matrix4x4.identity; //vissza állítjuk deafault-ra
    }
}
