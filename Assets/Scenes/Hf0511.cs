using UnityEngine;

 class Hf0511 : MonoBehaviour
{
    [SerializeField] float speed = 5;

    Vector3 targetPos; // eltettünk egy változót aminek az értéke nem veszik el és késõbb felülírjuk azt -fieldbe tettük

     void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        Vector3 input = GetInputDirection();

        if (input != GetInputDirection()) 
        targetPos += input;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D); //getkeydown csak egyszer megy nem folyamatosan mint a getkeynél
        bool leftButton = Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A);
        bool upButton = Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
        bool downButton = Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S);

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= 1;
        }

        float y = 0;
        if (upButton)
        {
            y += 1;
        }
        if (downButton)
        {
            y -= 1;
        }

        Vector3 jump = new Vector3(x, y, 0);
        return jump.normalized;
    }
}
