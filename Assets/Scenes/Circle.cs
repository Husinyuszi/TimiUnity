using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

 class Circle : MonoBehaviour
{
    [SerializeField] float radius = 1;  // csak fejlesztõknek van 
    [SerializeField] float circumferance;
    [SerializeField] float area;


     void OnValidate()
    {
        // float pi = 3.14f érték helyére lehet írni a pi-t Mathf.PI matematikai PI , ami szerepel az adatbázisban
        circumferance = 2* radius * 3.14f ; //kerület
        area = radius * radius *3.14f;  // terület

       // Debug.Log($ "Ker: {circleference} Ter: {area}");


    }








}
