using Unity.VisualScripting;
using UnityEngine;

 class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10; //gyorsul�s
    [SerializeField] float deceleration=10; //lassul�s
    [SerializeField] float maxSpeed = 10;
    [SerializeField] float jumpSpeed = 10;
    [SerializeField] new Rigidbody2D rigidbody;

    bool isGrounded = false;

     void OnValidate()
    {
        if (rigidbody==null)
            rigidbody= GetComponent<Rigidbody2D>();
    }

     void FixedUpdate() //gyorsul�/sebess�g mozg�sn�l c�lszer� ezt haszn�lni pl id� �s sebess�g f�ggv�ny -Update -n�l od�bbtenni �s pillanatnyi r�sz �tteeni
    {
        float x = Input.GetAxis("Horizontal"); //folyamatos v�ltoz�s ez�rt ezzel k�nnyebb lek�rdezni a horizont�lt
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
        bool jump = Input.GetKeyDown(KeyCode.Space); // pillanatnyi v�ltoz�s ez�rt nem az getaxis-st haszn�ljuk

        if (jump&&isGrounded)
        {
            velocity.y = jumpSpeed;
            //velocity += Vector2.up * jumpSpeed; nem kell deltatimmal szorozni, ezzel a k�t megold�ssal tudunk m�g a leveg�ben ugrani

        }
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision) // innent�l m�r csak a f�ldr�l lehet ugorni 
    {
        isGrounded = true;
    }

     void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded= false;
    }
}
