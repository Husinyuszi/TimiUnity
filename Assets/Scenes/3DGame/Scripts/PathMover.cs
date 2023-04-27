using UnityEngine;

 class PathMover : MonoBehaviour
{
    /*[SerializeField] Vector3 point1, point2;
    //[SerializeField] Transform t1, t2; üres gameobjectekhez adva mozgatás egyszerûbb lenne
    [SerializeField] float speed = 2;

    Vector3 nextTarget;

    private void Start()
    {
        nextTarget = point2;
        transform.position = point1;
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextTarget, speed * Time.deltaTime);

        if (transform.position==nextTarget) 

        {
            nextTarget = nextTarget == point1 ? point2 : point1;
            //if(nextTarget == point1)
            //    nextTarget = point2;
            //else
            //    nextTarget = point1; ez a 4 sor ugyan az mint a nextTarget=-vel kezdetû

        }
    }

     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(point1, 0.2f);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(point2, 0.2f);

        Gizmos.color = Color.white;
        Gizmos.DrawLine(point1, point2);
    }*/

    [SerializeField] Transform t1, t2;
    [SerializeField] Color c1, c2;
    [SerializeField] Transform movable;
    [SerializeField] float speed = 2;

    [SerializeField, Range(0, 1)] float startPoint = 0.5f;
    Vector3 nextTarget;

     void OnValidate()
    {
        movable.position = Vector3.Lerp(t1.position, t2.position, startPoint);
    }
    void Start()
    {
        Vector3 p1 = t1.position;
        Vector3 p2 = t2.position;

        //Vector3 p = startPoint * p2 + (1 - startPoint) * p1;

        Vector3 p= Vector3.Lerp(p1, p2, startPoint); //ez ugyan az mint az elõzõ sor, átlagolás, ha nem pont a felénél kezdünk Lerp átmenet A->B pontba v színekbe stb.


        nextTarget = t2.position;
        movable.position = p;
    }

    void Update()
    {
        movable.position =
            Vector3.MoveTowards(movable.position, nextTarget, speed * Time.deltaTime);

        if (movable.position == nextTarget)
        {
           

            nextTarget = nextTarget == t1.position ? t2.position : t1.position;
        }
    }

    void OnDrawGizmos()
    {
        //c1.a = 0.5f; 0-1 ig terjed az átlászhatóság

        Gizmos.color = c1;
        Gizmos.DrawSphere(t1.position, 0.2f);

        Gizmos.color = c2;
        Gizmos.DrawSphere(t2.position, 0.2f);

        Gizmos.color = Color.Lerp( c1, c2 ,startPoint);
        Gizmos.DrawLine(t1.position, t2.position);
    }
}
