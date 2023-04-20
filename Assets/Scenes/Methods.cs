using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

 class Methods : MonoBehaviour
{ 
    
    void Start() // void nincs vissza tértési értéke -Start is methodus- létrehozáskor már indítja is a void startot, methódus csak osztályon belül lehet 
    {

        int a = -45;

        int abs = Mathf.Abs(a);
        int min = Mathf.Min(a, 10);
        int max = Mathf.Max(0, 10, -5, 4);

        int myAbs;
        if (a<0)
        {
            myAbs = -a; 
        }
        else 
        {
            myAbs = a;
        }

        int myAbs2 = MyAbs(myAbs);
        int myAbs3 = MyAbs(-6);
        int myAbs4 = MyAbs(555);

        float power = Mathf.Pow(23.5f, 4.5f);
        float power2 = MyPow(23.5f, (int) 4.5f); // castolás a intbõl floatba- fordítva automatikus

        float sign = Mathf.Sign(-254);

        MultiplicationTable(10);
        MultiplicationTable(3);
        MultiplicationTable(100); // értéket kér amit nekünk kell megadni neki

        float f;

        f = Mathf.Clamp (power, -10, 10); // két érték közé szorítjuk be a függvény értékeit
        f = Mathf.Clamp01(power2); //0 és 1 közé beszorító függvény
        f = Mathf.Ceil(f); // felfelé kerekít float típusút ad
        f = Mathf.Floor(f); // lefelé kerekít float típusút ad

        int i;
        i = Mathf.CeilToInt(f); //int értékbe adjuk meg float lesz automatikusan castol 
        i = Mathf.FloorToInt(f);
        i = Mathf.RoundToInt(f);

        f = Mathf.Pow(f, 5); //hatványozás
        f = Mathf.Sqrt(f); // négyzetgyök
        f = Mathf.Pow(f, 1 / 3f); // floatnál f-et kirakni ->köbgyök


    }

    int MyAbs (int num)  //beírjuk, h milyen bemenetet várunk pl int 
    {
        int myAbs;
        if (num < 0)
        {
            myAbs = -num;
        }
        else
        {
            myAbs = num;
        }
        return myAbs;
    }


    float MyPow (float baseNumber, int exponent) // számít a sorrend megadása és a típus is 
    {
        float result = 1;
        for (int i=0; i< exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }

    float mySign (float number)
    {
        
        if (number < 0)
        {
            return -1;
        }
        else
        {
            return 1;
        } 

    }
    void MultiplicationTable(int number)  // szorzótábla
    {
        for (int i = 0; i <= number; i++)
        {
            for (int j = 0; j <= number; j++)
            {
                string s = $"{j} * {i} = {i * j}";
                Debug.Log(s);
            }
        }
    }

    float Floor (float n) 
    {
        float r = n % 1;
        return n - r;
    }

    int FloorToInt (float n )
    {
        return (int)n;
    }

    float Ceil(float n)
    {
        float r = n % 1;
            if (r==0)
        {
            return n;       
        }
        return n - r + 1;
    }

    //float Round (float n)
        
    bool IsPrime (int n) 
    {
        if (n%2==0)
        {
            return false;
        }
        for (int i =2; i <n; i++)
        {
            if (n % 1 == 0)
            {
                return false;
            }
        }
        return true;
    }

    float Min(float a, float b) 
    {
       /* if (a<b) 
        {
            return a;
        }
        else
        {
            return b;*/

            return a < b ? a : b;
        }
    float Max( float a, float b ) // => (nyíl) a> b ? a:b; egy parancssornál , ez expresson body jobb klikk quick action 
    {
        return a> b ? a : b;
    }

    }

    

