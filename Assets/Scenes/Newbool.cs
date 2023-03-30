using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

 class Newbool : MonoBehaviour
{
    
    void Start ()

    {
        bool b1 = true;
        bool b2 = false;

        b1 = false;

        int i1 = 33, i2 = 33;

        bool intsAreEqual = i1 == i2; //t
        bool i1IsHigherThani2 = i1 > i2; //f
        bool i1IsLowerhani2 = i1 < i2; //f

        bool i1IsHigherorEqualThanIsi2 = i1 >= i2; //t
        bool i1IsLowerorEqualThanIsi2 = i1 <= i2; //t

        bool stringAreNotEqual = i1 != i2; //f

        bool stringsAreequal = "aaaa" == "AAAA"; // f
        bool stringsArenotEqual = "aaaa" != "AAAA"; //t

        //--------------------------------------------

        int ammo = 50;
        bool isAlive = true;
        bool haveAmmo = ammo > 0;

        bool canShoot = isAlive && haveAmmo;

        float height = 12;
        bool canAirJump = false;

        bool canJump = canAirJump || height == 0; //kifejezés ami egy értékeit fejez ki, és tudunk -e ugrani -false

        bool isInAir = height > 0;
        bool isGrounded = !isInAir;

        canJump = canAirJump || !isInAir; //f


        bool b3 = b1 ^ b2; //XOR=kizáró vagy -sörözõs példa



    }
}
