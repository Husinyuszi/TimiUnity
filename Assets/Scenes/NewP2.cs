using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

class NewP2 : MonoBehaviour
{
    [SerializeField] [Min (0)] int intField = 5; // értékek megadása indításnál- akár a unityben  min érték -max érték nincs 
    [SerializeField] [Range (0,10)] float floatField = 7.77f; // floatfield a megadott értékek között legyen, változó fel tudja venni
    [SerializeField] string stringField = "hello";
    [SerializeField] bool boolField = true; 


    void Start()
    {
        int i = 4;
        float f = 1.54f;
        string s = "Ez az elsõ string-em";
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

        float f7 = i1 / (float)i2;  // véges a pontossága-tört és tizedes ( 1/3 és 0,333..) 32 bit -lebegõpontos típus

        double d = 23.5678; // dupla annyi biten tárolva 
        long l = 123456; // szintén dupla bit, csak kieg a double és a long képzésnél

        float f8 = (float)5; // automatikus castolás floatnál int-bõl
        int i3 = (int)34.56f; // intnél nem automatikus a castolás

        //-----------------

        string s2 = s + "Akármi"; // + szöveg összefûzés
        string s3 = s2 + 15;

        Debug.Log(s3); // kiíratás átnevezés pl f2 ->22-re jobb klikk, ctrl rr, ctrl f (keresés szövegben v kijelölt szövegben) ott átnevezés

        string s4 = "A korom:" + f1 + "A magasságom:" + f2; 
        string s5 = $"A korom: {f1}, a magasságom: {f2} qn \t \\ {{ghgtf }}";

        string s6 = f7.ToString();
        string s7 = "76";

        int i4 = int.Parse(s7); // Nem garantál -képzésnél nem fogjuk használni













    }

}