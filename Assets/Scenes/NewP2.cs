using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

class NewP2 : MonoBehaviour
{
    [SerializeField] [Min (0)] int intField = 5; // �rt�kek megad�sa ind�t�sn�l- ak�r a unityben  min �rt�k -max �rt�k nincs 
    [SerializeField] [Range (0,10)] float floatField = 7.77f; // floatfield a megadott �rt�kek k�z�tt legyen, v�ltoz� fel tudja venni
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true; 


    void Start()
    {
        int i = 4;
        float f = 1.54f;
        string s = "Ez az els� string-em";
        bool b1 = true;
        bool b2 = false;


        var v1 = "string";
        var v2 = 12.5f;
        var v3 = 56;
        var v4 = false;

        //--------------

        float f1 = f + 4;
        float f2 = f1 - f;
        float f3 = f2 * f;
        float f4 = f2 / f;
        float f5 = f2 % f;

        float f6 = 3 / 2f; // pontos

        int i1 = 3, i2 = 2;

        float f7 = i1 / (float)i2;  // v�ges a pontoss�ga-t�rt �s tizedes ( 1/3 �s 0,333..) 32 bit -lebeg�pontos t�pus

        double d = 23.5678; // dupla annyi biten t�rolva 
        long l = 123456; // szint�n dupla bit, csak kieg a double �s a long k�pz�sn�l

        float f8 = (float)5; // automatikus castol�s floatn�l int-b�l
        int i3 = (int)34.56f; // intn�l nem automatikus a castol�s

        //-----------------

        string s2 = s + "Ak�rmi"; // + sz�veg �sszef�z�s
        string s3 = s2 + 15;

        Debug.Log(s3); // ki�rat�s �tnevez�s pl f2 ->22-re jobb klikk, ctrl rr, ctrl f (keres�s sz�vegben v kijel�lt sz�vegben) ott �tnevez�s

        string s4 = "A korom:" + f1 + "A magass�gom:" + f2; 
        string s5 = $"A korom: {f1}, a magass�gom: {f2} qn \t \\ {{ghgtf }}";

        string s6 = f7.ToString();
        string s7 = "76";

        int i4 = int.Parse(s7); // Nem garant�l -k�pz�sn�l nem fogjuk haszn�lni













    }

}