using UnityEngine;

class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    void Start() { }


    void Update()
    {
        Vector3 direction = GetInputDirection();
        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime;
    }

    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow);
        bool upButton = Input.GetKey(KeyCode.UpArrow);
        bool downButton = Input.GetKey(KeyCode.DownArrow);

        float x = 0;
        if (rightButton)
        {
            x += 1;
        }
        if (leftButton)
        {
            x -= -1;
        }

        float z = 0;
        if (upButton)
        {
            z += 1;
        }
        if (downButton)
        {
            z -= -1;
        }

        Vector3 d = new Vector3(x, 0, z);
        d.Normalize();
        return d;
    }
}


/*using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    void Start()
    {
        /*
        Transform t = transform;

        Vector3 p = t.position;

        Debug.Log(p);

        t.position = new Vector3(2, 3, 4);
        transform.position= new Vector3 (6,7,8); // Egyszerûbben leírva a pozicionálás

        Debug.Log("Magasság: " + transform.position.y);

        // transform.position.x = 3f; Nem használható !!! Error

        Vector3 pos = t.position; //t.=transform mivel ki lett emelve fent
        pos.y = 3;
        transform.position = pos; 
        


    }

     void Update() // képrisítéshez mérten fut le ahányszor a kép frissétés
    {
        //Vector3 velocity = Vector3.right * speed; //melyik irányban megy adottan nem szabad a mozgás 

        Vector3 direction = Vector3.right;

        bool upButton = Input.GetKey(KeyCode.UpArrow);
        bool downButton = Input.GetKey(KeyCode.DownArrow);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow);
        bool rightButton = Input.GetKey(KeyCode.RightArrow);

        float x = 0;
        if (rightButton) gombnyomásnál csak az egyik irányba lehesssen menni jobbra és balra -hozzá adunk és elvonunk akkor nulla és megáll ugyan ez fel és le opciónál 
        {
            x = 1;
        }
        else if (leftButton)
        {
            x = -1;
        }

        float z = 0;
        if (upButton)
        {
            z = 1;
        }
        else if (downButton)
        {
            z = -1;
        }

        Vector3 d = new Vector3(x,0,z);
        d.Normalize(); // Normalizáéja h keresztbe is egy egység legyen 
        return d;



       Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime; // Time.deltaTime képfrissítési idõhöz mérten egyenletes változást érünk el-Frame rate független legyen 



    }
} */

