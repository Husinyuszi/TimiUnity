using UnityEngine;

public class PoseSaver : MonoBehaviour
{
    [SerializeField] string uniqueId;

    void Start()
    {
        // Bet�lt�s

        if (PlayerPrefs.HasKey(uniqueId + " position x"))
        {
            float x = PlayerPrefs.GetFloat(uniqueId + " position x");
            float z = PlayerPrefs.GetFloat(uniqueId + " position z");

            transform.position = new Vector3(x, 0, z);
        }
    }

    void OnDestroy()
    {
        float x = transform.position.x;
        float z = transform.position.z;

        //  Ment�s
        PlayerPrefs.SetFloat(uniqueId + " position x", x);
        PlayerPrefs.SetFloat(uniqueId + " position z", z);
    }

    void DeleteSaveData()
    {
        PlayerPrefs.DeleteKey(uniqueId + " position x");
        PlayerPrefs.DeleteKey(uniqueId + " position y");
    }
}

/*void Start()
    {
        //bet�lt�s

        if (PlayerPrefs.HasKey("position x"))
        { 
            float x = PlayerPrefs.GetFloat("position x");
            float z = PlayerPrefs.GetFloat("position z");


            transform.position = new Vector3(x, 0, z);

        }
    }
    void OnDestroy() //start ellentettje 
    {
        float x =transform.position.x;
        float z =transform.position.z;

        //ment�s
        PlayerPrefs.SetFloat("position x",x); //els� adat kulcsnak nevezett adat
        PlayerPrefs.SetFloat("position z",z);
    }

    void DeleteSaveData() 
    {
        PlayerPrefs.DeleteKey("position x");
        PlayerPrefs.DeleteKey("position z");
    }
}*/
