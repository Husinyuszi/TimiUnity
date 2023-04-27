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
        list1[10] = 76; //error ki lett véve egy elem emiattt már nincs 10.

        list1.RemoveAt(1); //mindig az elsõ ( ami a 2. ) elemet veszi ki -indexen lévõ elem
        bool success= list1.Remove(12201); // ekkor az adott pl számot veszi ki a listából-kiveszem az értéket -sikerült -e?

        list1.Insert(0, 2123421); // az adott helyre adunk értéket

        list1.Clear(); // töröljük az adott lista értékeit

        bool contains= list1.Contains(10); // tartalmazz-e az adott elemt? 

        int index= list1.IndexOf(12201); // hanyadik a sorban az adott elem?

        list1.Sort(); // sorba teszi a számokat a tömbben 



        /*float mean1 = Mean(2, 6);
        float mean2 = Mean(2, 6, 7);

        float[] a1 = new float[] { 1, 3, 5, 7, 2, 2 };
        float mean3 = Mean (1, 3, 5, 7, 2, 2);
        float mean4 = Mean(new float[] { 1, 3, 5, 4 });
        float mean5 = Mean(a1);

        Debug.Log(mean3);


        float[] array1 = new float[10]; // tömb(= adott fv összesége) létrehozása , pl float típusú és annak értéket kell adni pl 10

        array1[0] = 0.55f;
        array1[1] = 1.53f;
        array1[2] = 2.95f;
        //... 
        array1[9] = 11.66f;

        for (int i=0; i < array1.Length; i++) 
        {
            array1[i] = i; //array1[i]= arrey.Length -i vissza felé adva meg
        }

        string[] array2 = new string[] { "Alma", "Körte", "Banán" };
        int[] array3 = new int[] { 1, 5, 66, 77, 89 };

        Debug.Log(array2[1]);
        Debug.Log(array2[3]); // error , mert nincs 3. eleme ( nulla az elsõ)*/


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
        foreach (float f in array) //végig lépegethetõ dolgokon mûködik a forech -tömbök-listák
        {
            if (f < min)
                min = f;
        }
        return min;
    }


}
