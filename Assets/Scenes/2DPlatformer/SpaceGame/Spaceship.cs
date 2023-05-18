using UnityEngine;

 class Spaceship : MonoBehaviour
{
    [SerializeField] float maxSpeed=10;
    [SerializeField] float acceleration=5;
    [SerializeField] float angularSpeed = 180;
    [SerializeField] float drag = 1;

    Vector2 velocity;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        if (x != 0) 
        {
            transform.Rotate(0, 0, angularSpeed* -x * Time.deltaTime);
        
        }

       /* if (y > 0) 
        {
            velocity += (Vector2)transform.up * (acceleration * Time.deltaTime);
                                                                                  gyorsulás miatt rakjuk át fixedupdateba
        }*/ 

        //transform.position += transform.up * y * maxSpeed * Time.deltaTime;//ha y-nal beszorozzuk vagyis önmagával akkor szép lassan indul meg és lassan áll meg
        transform.position += (Vector3)velocity * Time.deltaTime;
    }

     void FixedUpdate()
    {
        float y = Input.GetAxis("Vertical");
        if (y > 0)
        {
            velocity += (Vector2)transform.up * (acceleration * Time.fixedDeltaTime);
            if (velocity.magnitude> maxSpeed) 
                velocity=velocity.normalized*maxSpeed;
        }

        velocity-= velocity*(drag*Time.fixedDeltaTime);
    }
}
