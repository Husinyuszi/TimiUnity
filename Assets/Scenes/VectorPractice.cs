using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    
    void Start()
    {
        Vector2 v2;
        Vector3 v3;

        v2 = new Vector2(3, 7);   // koordináták megadása (x,y)-y vector3-nél (x,y,z) 
        v3 = new Vector3(3, 7, 8);  // ha a z-nek nem adunk értéket akkor 0

        v3 = new Vector3(); // üresen hagyva 0-zéró a kezdõhely 
        v3 = new Vector3(1, 2); // z=0

        //egység értékek
        v3 = Vector3.right; //x=1, y és z 0
        v3 = Vector3.left;//x=-1, y és z 0
        v3 = Vector3.up; // x=0 y=1 z =0
        v3 = Vector3.down; //y=-1 y és z 0
        v3 = Vector3.forward; // z=1 x és y 0
        v3 = Vector3.back;// z=-1 x és y 0

        //Mûveletek

        Vector3 vSum = v3 + new Vector3(1, 2, 3);
        Vector3 vDif = vSum - Vector3.left;
        Vector3 vMult = v3 * 10;
        Vector3 vDiv = vSum / 10;

        //típus változó neve= értéke
        float lenght = v3.magnitude; //típusokra figyelni kell hiába vectornak adunk hosszt akkor is float kell a hossznak
        Vector3 normalized = v3.normalized; //normalizált vektorok egység hosszúak 

        v3.Normalize(); // itt a vektor értéke már meg változott normalizálás miatt

        float x = v3.x;
        float y = v3.y;
        float z = v3.z;





    }

}
