using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOTestComponent : MonoBehaviour
{
    
        [SerializeField] TestScriptableObject test;

 /*   using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "TestSO", menuName = "MyGame/Something/TestSO")]
public class TestScriptableObject : ScriptableObject
{
    [SerializeField] Vector3 testVector;
    [SerializeField] List<string> testList;
    [SerializeField] GameObject testGameObject;

    [SerializeField] TestScriptableObject so1;
    [SerializeField] TestScriptableObject so2;
}


//---------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoTestComponent : MonoBehaviour
{
    [SerializeField] TestScriptableObject test;

}

//------------------------------------------------------

using UnityEngine;
using static Unity.VisualScripting.Member;

public class TriggerSoundPlayer : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] SoundGroup group;


    void OnTriggerEnter2D(Collider2D collision)
    {
        AudioClip clip = group.GetRandomClip();

        source.clip = clip;
        source.Play();
    }
}

//------------------------------------------------------


using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SoundGroup : ScriptableObject
{
    [SerializeField] List<AudioClip> clips;

    int lastSoundIndex = -1;

    public AudioClip GetRandomClip()
    {
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, clips.Count);
        }
        while (randomIndex == lastSoundIndex && clips.Count > 1);

        lastSoundIndex = randomIndex;
        return clips[randomIndex];
    }
}*/

}
