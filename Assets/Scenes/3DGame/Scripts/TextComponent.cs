using UnityEngine;

enum Direction { North, South, East, West } //érték típus

[System.Serializable]
struct MyVector2 //érték t.
{
    public float x, y;
    public string sss;
    public bool bbb;

    public MyVector2(float x, float y) 
    { 
        this.x = x;
        this.y = y;
        sss = "asd";
        bbb = true;
    }
}
[System.Serializable]
class MyVector3 //referencia típusú
{ 
    public float x, y, z;
}

public class TextComponent : MonoBehaviour
{
    [SerializeField] Direction directionAsASetting;
    [SerializeField] MyVector2 vectorAsASetting;
    [SerializeField] MyVector3 vector3AsBSetting;


    void Start()
    {
        int i = 2;
        Direction myDirection = Direction.East;
        MyVector2 v2 = new MyVector2(1,2);
        MyVector3 v3 = new MyVector3() { x= 2, y = 3, z = 4 };
        v3.x = 2;

        Debug.Log(vectorAsASetting.bbb);

        int a = 4;
        int b = a;
        b++;
        Debug.Log(a); //4 -érték típusú
        MyMethod(a);
        Debug.Log(a); // 4

        //----------------

        int[] ta = { 1, 2, 3 };
        int[] tb = ta;
        tb[0] = 33;
        Debug.Log(ta[0]); // 33
        MyMethod2(ta);
        Debug.Log(ta[0]); // 34
    }

    void MyMethod(int i) //érték t.
    {
        i++;
    }
    void MyMethod2(int[] i)// referencia t.
    {
        i[0]++;
    }


}

