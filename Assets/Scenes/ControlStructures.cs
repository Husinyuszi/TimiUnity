using UnityEngine;

 class ControlStructures : MonoBehaviour
{
    [SerializeField] int a, b; 
     void Start()
    {
        //Innen

        // bool aHigherThanb =a>b
        
        if(a>b)
        {
            Debug.Log("A nagyobb, mint B. "); 
        }

        else if (a<b)
        {
            Debug.Log("A kisebb, mint B.");
        }
        else 
        {
            Debug.Log("A �s B egyenl�.");
        }

        //-----------------------------

        if (a % 2 == 0)
        {
            Debug.Log("A P�ros");

        }
        else
        {
            Debug.Log("A p�ratlan ");
        }
        //----------------------

        bool aDevidableb = a % b == 0;
        bool bDevidablea = b % a == 0;

        if (aDevidableb)
        {
            Debug.Log("A oszthat� B-vel.");
        }

        if (bDevidablea)
        {
            Debug.Log("B oszthat� A-val.");
        }

        if (!aDevidableb && bDevidablea)
        {
            Debug.Log("A �s B nem oszthat� egym�ssal.");
        }

        int number = 12354;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1:
                Debug.Log("Egy");
                break;
            case 2:
                Debug.Log("Kett�");
                break; // �s �gy tov�bb 
            case 9:
                Debug.Log("Kilenc");
                break;
             default:
                Debug.Log("Nulla");
                break;

        }

        //--------------------------------

        string pairity;
        if (number % 2 ==0)
        {
            pairity = "P�ros";
        }
         else
        {
            pairity = "P�ratlan";
        }

        pairity = number % 2 == 0 ? "P�ros" : "P�ratlan"; // a kett� ugyan az csak egyszer�bben le�rva

        //-------------------------------------------------------------

        int i = 1;

        while(i<=100) //ciklus -felt�telt adunk neki
        {
            Debug.Log(i);
            i++;
        }


        //Debug.Log(1);
        //Debug.Log(2);
        //Debug.Log(3); sz�mok ki�r�sa 1-t�l 100-ig (egyes�vel le�rva sok�ig tartana)

        //---------------------------------------------------------------

        
        i = 1;
        int count = 0;

        while (count<100)                       //el�l
        { 
         if (i% 3 == 0 || i % 7== 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;
        }

        //-------------------------------

        do
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                Debug.Log(i);
                count++;
            }
            i++;                            //h�tul
        } while (i < 100);


        //---------------------------------------------
        for (int j=0; j<100; j++)
        {
            int a = 5; // csak ebben a t�rzsben l�tezik 
            Debug.Log(a);
        }


        //Id�ig
    }


}
