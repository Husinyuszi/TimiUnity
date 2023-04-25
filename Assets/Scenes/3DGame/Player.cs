using UnityEngine;

class Player : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float angularSpeed = 180;
    void Start() { }


    void Update()
    {
        Vector3 direction = GetInputDirection();

        if (direction != Vector3.zero)
        {
            Vector3 velocity = direction * speed;
            transform.position += velocity * Time.deltaTime;

            //if (direction != Vector3.zero)
            Quaternion targetRot = Quaternion.LookRotation(direction);
            Quaternion currentRot = transform.rotation;

            float step= angularSpeed *Time.deltaTime; //angularspeed forg�si sebess�g
            transform.rotation = Quaternion.RotateTowards(currentRot, targetRot, step);

            //transform.rotation = Quaternion.LookRotation(direction);

            




        }
    }

    Vector3 GetInputDirection()
    {
        bool rightButton = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A); ;
        bool upButton = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W); ;
        bool downButton = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S); ;

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
        transform.position= new Vector3 (6,7,8); // Egyszer�bben le�rva a pozicion�l�s

        Debug.Log("Magass�g: " + transform.position.y);

        // transform.position.x = 3f; Nem haszn�lhat� !!! Error

        Vector3 pos = t.position; //t.=transform mivel ki lett emelve fent
        pos.y = 3;
        transform.position = pos; 
        


    }

     void Update() // k�pris�t�shez m�rten fut le ah�nyszor a k�p friss�t�s
    {
        //Vector3 velocity = Vector3.right * speed; //melyik ir�nyban megy adottan nem szabad a mozg�s 

        Vector3 direction = Vector3.right;

        bool upButton = Input.GetKey(KeyCode.UpArrow);
        bool downButton = Input.GetKey(KeyCode.DownArrow);
        bool leftButton = Input.GetKey(KeyCode.LeftArrow);
        bool rightButton = Input.GetKey(KeyCode.RightArrow);

        float x = 0;
        if (rightButton) gombnyom�sn�l csak az egyik ir�nyba lehesssen menni jobbra �s balra -hozz� adunk �s elvonunk akkor nulla �s meg�ll ugyan ez fel �s le opci�n�l 
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
        d.Normalize(); // Normaliz��ja h keresztbe is egy egys�g legyen 
        return d;



       Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime; // Time.deltaTime k�pfriss�t�si id�h�z m�rten egyenletes v�ltoz�st �r�nk el-Frame rate f�ggetlen legyen 



    }
} */

