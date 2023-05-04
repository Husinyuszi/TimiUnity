using UnityEngine;

 class Damager : MonoBehaviour
{
    [SerializeField] int damage = 1;
     void OnTriggerEnter(Collider other)
    {
       // Debug.Log("ENTER TRIGGER");
        //Debug.Log(other.name);

        Damageable damageable= other.gameObject.GetComponent<Damageable>();

        if (damageable !=null) 
        {
            // Debug.Log(other.name);
            damageable.Damage(damage);
        }
    }
}
