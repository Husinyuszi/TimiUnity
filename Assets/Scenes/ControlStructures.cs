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
            Debug.Log("A és B egyenlõ.");
        }

        //-----------------------------

        if (a % 2 == 0)
        {
            Debug.Log("A Páros");

        }
        else
        {
            Debug.Log("A páratlan ");
        }
        //----------------------

        bool aDevidableb = a % b == 0;
        bool bDevidablea = b % a == 0;

        if (aDevidableb)
        {
            Debug.Log("A osztható B-vel.");
        }

        if (bDevidablea)
        {
            Debug.Log("B osztható A-val.");
        }

        if (!aDevidableb && bDevidablea)
        {
            Debug.Log("A és B nem osztható egymással.");
        }

        int number = 12354;
        int lastDigit = number % 10;

        switch (lastDigit)
        {
            case 1:
                Debug.Log("Egy");
                break;
            case 2:
                Debug.Log("Kettõ");
                break; // és így tovább 
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
            pairity = "Páros";
        }
         else
        {
            pairity = "Páratlan";
        }

        pairity = number % 2 == 0 ? "Páros" : "Páratlan"; // a kettõ ugyan az csak egyszerûbben leírva

        //-------------------------------------------------------------

        int i = 1;

        while(i<=100) //ciklus -feltételt adunk neki
        {
            Debug.Log(i);
            i++;
        }


        //Debug.Log(1);
        //Debug.Log(2);
        //Debug.Log(3); számok kiírása 1-tõl 100-ig (egyesével leírva sokáig tartana)

        //---------------------------------------------------------------

        
        i = 1;
        int count = 0;

        while (count<100)                       //elöl
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
            i++;                            //hátul
        } while (i < 100);


        //---------------------------------------------
        for (int j=0; j<100; j++)
        {
            int a = 5; // csak ebben a törzsben létezik 
            Debug.Log(a);
        }


        //Idáig
    }


}
