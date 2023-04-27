using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking.Match;

class ArrayPractice : MonoBehaviour
{
    [SerializeField] float[] testArray;
    [SerializeField] float mean;
    [SerializeField] float max;

    void OnValidate()
    {
        mean = Mean(testArray);
        max = Max(testArray);
        //----------------------------

        List <int> list1 = new List<int>();
        list1.Add(201);
        list1.Add(21);
        list1.Add(12201);

        Debug.Log(list1[0]);
        list1[1] = 10;

        list1.Add(12201);
        list1[10] = 76; //error ki lett v�ve egy elem emiattt m�r nincs 10.

        list1.RemoveAt(1); //mindig az els� ( ami a 2. ) elemet veszi ki -indexen l�v� elem
        bool success= list1.Remove(12201); // ekkor az adott pl sz�mot veszi ki a list�b�l-kiveszem az �rt�ket -siker�lt -e?

        list1.Insert(0, 2123421); // az adott helyre adunk �rt�ket

        list1.Clear(); // t�r�lj�k az adott lista �rt�keit

        bool contains= list1.Contains(10); // tartalmazz-e az adott elemt? 

        int index= list1.IndexOf(12201); // hanyadik a sorban az adott elem?

        list1.Sort(); // sorba teszi a sz�mokat a t�mbben 



        /*float mean1 = Mean(2, 6);
        float mean2 = Mean(2, 6, 7);

        float[] a1 = new float[] { 1, 3, 5, 7, 2, 2 };
        float mean3 = Mean (1, 3, 5, 7, 2, 2);
        float mean4 = Mean(new float[] { 1, 3, 5, 4 });
        float mean5 = Mean(a1);

        Debug.Log(mean3);


        float[] array1 = new float[10]; // t�mb(= adott fv �sszes�ge) l�trehoz�sa , pl float t�pus� �s annak �rt�ket kell adni pl 10

        array1[0] = 0.55f;
        array1[1] = 1.53f;
        array1[2] = 2.95f;
        //... 
        array1[9] = 11.66f;

        for (int i=0; i < array1.Length; i++) 
        {
            array1[i] = i; //array1[i]= arrey.Length -i vissza fel� adva meg
        }

        string[] array2 = new string[] { "Alma", "K�rte", "Ban�n" };
        int[] array3 = new int[] { 1, 5, 66, 77, 89 };

        Debug.Log(array2[1]);
        Debug.Log(array2[3]); // error , mert nincs 3. eleme ( nulla az els�)*/


    }

   float Mean(float n1, float n2) 
    {
        return (n1+n2) / 2;
    }

    float Mean(float n1, float n2, float n3) 
    {
        return (n1 + n2 + n3) / 3;
    
    }

    float Mean(params float[] array) 
    {
        if (array.Length == 0)
            return float.MinValue;
        float sum = 0;
        for ( int i=0; i < array.Length;i++) 
        {
            float current = array[i];
            sum += current;
        
        }
        return sum / array.Length;
    }

    float Max(params float[] array) 
    {
        if (array.Length == 0)
            return float.MinValue;
        float max = array[0];
        for (int i = 1; i < array.Length; i++) ;
        {
            float current = array[1];
            if ( current > max)
                max = current;
        }
        return max;
    }

    float Min(params float[] array)
    {
        if (array.Length == 0)
            return float.MinValue;
        float min = array[0];
        /*for (int i = 1; i > array.Length; i++) ;
        {
            float current = array[1];
            if (current > min)
                min = current;*/
        foreach (float f in array) //v�gig l�pegethet� dolgokon m�k�dik a forech -t�mb�k-list�k
        {
            if (f < min)
                min = f;
        }
        return min;
    }


}
