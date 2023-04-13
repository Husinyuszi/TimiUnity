using Unity.VisualScripting;
using UnityEngine;

 class Methods : MonoBehaviour
{ 
    
    void Start() // void nincs vissza t�rt�si �rt�ke -Start is methodus- l�trehoz�skor m�r ind�tja is a void startot, meth�dus csak oszt�lyon bel�l lehet 
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
        float power2 = MyPow(23.5f, (int) 4.5f); // castol�s a intb�l floatba- ford�tva automatikus

        float sign = Mathf.Sign(-254);

        MultiplicationTable(10);
        MultiplicationTable(3);
        MultiplicationTable(100); // �rt�ket k�r amit nek�nk kell megadni neki

        float f;

        f = Mathf.Clamp (power, -10, 10); // k�t �rt�k k�z� szor�tjuk be a f�ggv�ny �rt�keit
        f = Mathf.Clamp01(power2); //0 �s 1 k�z� beszor�t� f�ggv�ny
        f = Mathf.Ceil(f); // felfel� kerek�t float t�pus�t ad
        f = Mathf.Floor(f); // lefel� kerek�t float t�pus�t ad

        int i;
        i = Mathf.CeilToInt(f); //int �rt�kbe adjuk meg float lesz automatikusan castol 
        i = Mathf.FloorToInt(f);
        i = Mathf.RoundToInt(f);

        f = Mathf.Pow(f, 5); //hatv�nyoz�s
        f = Mathf.Sqrt(f); // n�gyzetgy�k
        f = Mathf.Pow(f, 1 / 3f); // floatn�l f-et kirakni ->k�bgy�k


    }

    int MyAbs (int num)  //be�rjuk, h milyen bemenetet v�runk pl int 
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


    float MyPow (float baseNumber, int exponent) // sz�m�t a sorrend megad�sa �s a t�pus is 
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
    void MultiplicationTable(int number)  // szorz�t�bla
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

}
