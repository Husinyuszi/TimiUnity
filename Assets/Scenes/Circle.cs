using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

 class Circle : MonoBehaviour
{
    [SerializeField] float radius = 1;  // csak fejleszt�knek van 
    [SerializeField] float circumferance;
    [SerializeField] float area;


     void OnValidate()
    {
        // float pi = 3.14f �rt�k hely�re lehet �rni a pi-t Mathf.PI matematikai PI , ami szerepel az adatb�zisban
        circumferance = 2* radius * 3.14f ; //ker�let
        area = radius * radius *3.14f;  // ter�let

       // Debug.Log($ "Ker: {circleference} Ter: {area}");


    }








}
