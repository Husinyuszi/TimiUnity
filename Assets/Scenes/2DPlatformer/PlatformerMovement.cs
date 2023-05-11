using Unity.VisualScripting;
using UnityEngine;

 class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10; //gyorsulás
    [SerializeField] float deceleration=10; //lassulás
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] new Rigidbody2D rigidbody;

    bool isGrounded = false;

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
            velocity.x = Mathf.MoveTowards (velocity.x,0,deceleration-Time.fixedDeltaTime);
        }
        else // Acceleration

        {
            Vector2 accelerationVec = new Vector2(x * acceleration * Time.deltaTime, 0);
 
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

        if (jump&&isGrounded)
        {
            velocity.y = jumpSpeed;
            //velocity += Vector2.up * jumpSpeed; nem kell deltatimmal szorozni, ezzel a két megoldással tudunk még a levegõben ugrani

        }
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision) // innentõl már csak a földrõl lehet ugorni 
    {
        isGrounded = true;
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
    }
}
