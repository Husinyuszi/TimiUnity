using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    
    void Start()
    {
        Vector2 v2;
        Vector3 v3;

        v2 = new Vector2(3, 7);   // koordin�t�k megad�sa (x,y)-y vector3-n�l (x,y,z) 
        v3 = new Vector3(3, 7, 8);  // ha a z-nek nem adunk �rt�ket akkor 0

        v3 = new Vector3(); // �resen hagyva 0-z�r� a kezd�hely 
        v3 = new Vector3(1, 2); // z=0

        //egys�g �rt�kek
        v3 = Vector3.right; //x=1, y �s z 0
        v3 = Vector3.left;//x=-1, y �s z 0
        v3 = Vector3.up; // x=0 y=1 z =0
        v3 = Vector3.down; //y=-1 y �s z 0
        v3 = Vector3.forward; // z=1 x �s y 0
        v3 = Vector3.back;// z=-1 x �s y 0

        //M�veletek

        Vector3 vSum = v3 + new Vector3(1, 2, 3);
        Vector3 vDif = vSum - Vector3.left;
        Vector3 vMult = v3 * 10;
        Vector3 vDiv = vSum / 10;

        //t�pus v�ltoz� neve= �rt�ke
        float lenght = v3.magnitude; //t�pusokra figyelni kell hi�ba vectornak adunk hosszt akkor is float kell a hossznak
        Vector3 normalized = v3.normalized; //normaliz�lt vektorok egys�g hossz�ak 

        v3.Normalize(); // itt a vektor �rt�ke m�r meg v�ltozott normaliz�l�s miatt

        float x = v3.x;
        float y = v3.y;
        float z = v3.z;





    }

}
