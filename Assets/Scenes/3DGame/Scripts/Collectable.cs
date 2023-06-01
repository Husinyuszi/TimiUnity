using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Collectable : MonoBehaviour
{
    [SerializeField] int value = 1;
    [SerializeField] Bounds teleportArea;

    public int Value => value;

    public void Jump()
    {
        float x = Random.Range(teleportArea.min.x, teleportArea.max.x);
        float y = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float z = Random.Range(teleportArea.min.z, teleportArea.max.z);
        transform.position = new(x, y, z);

    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);

        /*
        var renderer = GetComponent<MeshRenderer>();
        Bounds rendererB = renderer.bounds;
        Gizmos.DrawWireCube(rendererB.center, rendererB.size);

        var collider = GetComponent<Collider>();
        Bounds colliderB = collider.bounds;
        Gizmos.DrawWireCube(colliderB.center, colliderB.size);
        */
    }
}

