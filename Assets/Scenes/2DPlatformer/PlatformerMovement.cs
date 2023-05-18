using Unity.VisualScripting;
using UnityEngine;

 class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10; //gyorsulás
    [SerializeField] float deceleration=10; //lassulás
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField, Min(0)] int airJumpCount;
    [SerializeField] Vector2  legposition= new Vector2( 0,-1);
    [SerializeField] float legRadius = 0.2f;
    [SerializeField] new Rigidbody2D rigidbody;

    bool isGrounded = false;
    int airJumpBudget = 0;
    float xDirection = 1;

    public Vector2 GetFacingDirection()
    { 
        return xDirection* Vector2.right; 
    }

     void OnValidate()
    {
        if (rigidbody==null)
            rigidbody= GetComponent<Rigidbody2D>();
    }

     void FixedUpdate() //gyorsuló/sebesség mozgásnál célszerû ezt használni pl idõ és sebesség függvény -Update -nél odébbtenni és pillanatnyi rész átteeni
    {
        float x = Input.GetAxis("Horizontal"); //folyamatos változás ezért ezzel könnyebb lekérdezni a horizontált
        Vector2 velocity = rigidbody.velocity;

        if (x == 0) // Deceleration
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, deceleration * Time.fixedDeltaTime);
        }
        else // Acceleration

        {
            Vector2 accelerationVec = new Vector2(x * acceleration, 0);
 
            //velocity.x = x* movementSpeed;
            velocity += accelerationVec * Time.fixedDeltaTime;
            //rigidbody.AddForce(accelerationVec, ForceMode2D.Force);


            if (Mathf.Abs(velocity.x) > maxSpeed) 
            velocity.x = maxSpeed * Mathf.Sign(velocity.x);
        }
      
        rigidbody.velocity = velocity;
    }

     void Update()
    {
        Vector2 velocity = rigidbody.velocity;
        bool jump = Input.GetKeyDown(KeyCode.Space); // pillanatnyi változás ezért nem az getaxis-st használjuk

        if (jump&& (isGrounded || airJumpCount>0))
        {
            if (!isGrounded)
                airJumpCount--;

            Debug.Log(airJumpBudget);

            velocity.y = jumpSpeed;
            //velocity += Vector2.up * jumpSpeed; nem kell deltatimmal szorozni, ezzel a két megoldással tudunk még a levegõben ugrani

        }
        rigidbody.velocity = velocity;

        SetupScale(velocity.x);
    }

    void SetupScale(float x)
    {
        if (x != 0)
        {
            Vector3 scale = transform.localScale;
            xDirection = Mathf.Sign(x); //lövéséhez melyik irányba állunk. Mindig elõre lõjön csak
            scale.x = Mathf.Sign(x);
            transform.localScale = scale;
        }
    }


    void OnCollisionEnter2D(Collision2D collision) // innentõl már csak a földrõl lehet ugorni 
    {
        Debug.Log("Reload: " + airJumpBudget);
        airJumpBudget = airJumpCount;
        isGrounded = true;

        Vector2 point = collision.contacts[0].point;//csak az alját érzékelje ugrásnál az oldalát ne érzékelje , úgy h a földön van
        Vector3 legWorld = transform.TransformPoint(legposition);
        float distance = Vector3.Distance(point, legWorld);
        if (distance < legRadius)
        {
            Debug.Log("Reload: " + airJumpBudget);
            airJumpBudget = airJumpCount;
            isGrounded = true;
        }
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
    }

     void OnDrawGizmosSelected()
    {
        //Gizmos.matrix=transform.localToWorldMatrix; saját transzformnak a mátrixát kérjük be és a saját világba konvertálja át 
        Vector2 p = legposition;
        Vector3 pWorld=transform.TransformDirection(p);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(p, legRadius);
        //Gizmos.matrix=Matrix4x4.identity rendarakás h visssza állítsa a világba és ne a az saját világba legyen
    }
}
