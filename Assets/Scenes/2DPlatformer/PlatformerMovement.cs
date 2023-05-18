using Unity.VisualScripting;
using UnityEngine;

 class PlatformerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float acceleration = 10; //gyorsul�s
    [SerializeField] float deceleration=10; //lassul�s
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

     void FixedUpdate() //gyorsul�/sebess�g mozg�sn�l c�lszer� ezt haszn�lni pl id� �s sebess�g f�ggv�ny -Update -n�l od�bbtenni �s pillanatnyi r�sz �tteeni
    {
        float x = Input.GetAxis("Horizontal"); //folyamatos v�ltoz�s ez�rt ezzel k�nnyebb lek�rdezni a horizont�lt
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
        bool jump = Input.GetKeyDown(KeyCode.Space); // pillanatnyi v�ltoz�s ez�rt nem az getaxis-st haszn�ljuk

        if (jump&& (isGrounded || airJumpCount>0))
        {
            if (!isGrounded)
                airJumpCount--;

            Debug.Log(airJumpBudget);

            velocity.y = jumpSpeed;
            //velocity += Vector2.up * jumpSpeed; nem kell deltatimmal szorozni, ezzel a k�t megold�ssal tudunk m�g a leveg�ben ugrani

        }
        rigidbody.velocity = velocity;

        SetupScale(velocity.x);
    }

    void SetupScale(float x)
    {
        if (x != 0)
        {
            Vector3 scale = transform.localScale;
            xDirection = Mathf.Sign(x); //l�v�s�hez melyik ir�nyba �llunk. Mindig el�re l�j�n csak
            scale.x = Mathf.Sign(x);
            transform.localScale = scale;
        }
    }


    void OnCollisionEnter2D(Collision2D collision) // innent�l m�r csak a f�ldr�l lehet ugorni 
    {
        Debug.Log("Reload: " + airJumpBudget);
        airJumpBudget = airJumpCount;
        isGrounded = true;

        Vector2 point = collision.contacts[0].point;//csak az alj�t �rz�kelje ugr�sn�l az oldal�t ne �rz�kelje , �gy h a f�ld�n van
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
        //Gizmos.matrix=transform.localToWorldMatrix; saj�t transzformnak a m�trix�t k�rj�k be �s a saj�t vil�gba konvert�lja �t 
        Vector2 p = legposition;
        Vector3 pWorld=transform.TransformDirection(p);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(p, legRadius);
        //Gizmos.matrix=Matrix4x4.identity rendarak�s h visssza �ll�tsa a vil�gba �s ne a az saj�t vil�gba legyen
    }
}
